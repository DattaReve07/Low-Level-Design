using Proxy.ActualDAO;

namespace Proxy.Proxy;

public class EmployeeDaoProxy(EmployeeDaoImpl daoObject, AccessRoles role) : EmployeeDAO
{
    public string GetEmployeeName(int employeeId)
    {
        Console.WriteLine("Proxy: Checking access before getting employee name");
        return role is AccessRoles.ADMIN or AccessRoles.USER
            ? daoObject.GetEmployeeName(employeeId)
            : throw new UnauthorizedAccessException("Access denied: insufficient permissions");
    }

    public void AddEmployee(string employeeName)
    {
        Console.WriteLine("Proxy: Checking access before adding employee");
        if (role != AccessRoles.ADMIN)
        {
            throw new UnauthorizedAccessException("Access denied: insufficient permissions");
        }
        daoObject.AddEmployee(employeeName);
    }

    public void DeleteEmployee(int employeeId)
    {
        Console.WriteLine("Proxy: Checking access before deleting employee");
        if (role != AccessRoles.ADMIN)
        {
            throw new UnauthorizedAccessException("Access denied: insufficient permissions");
        }
        daoObject.DeleteEmployee(employeeId);
    }
}