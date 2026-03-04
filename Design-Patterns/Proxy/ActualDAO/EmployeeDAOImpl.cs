namespace Proxy.ActualDAO;

public class EmployeeDaoImpl : EmployeeDAO
{
    public string GetEmployeeName(int employeeId)
    {
        Console.WriteLine($"Employee with id {employeeId} found");
        return "John Doe";
    }

    public void AddEmployee(string employeeName)
    {
        Console.WriteLine($"Adding {employeeName} to database");
    }

    public void DeleteEmployee(int employeeId)
    {
        Console.WriteLine($"Deleting employee with ID {employeeId} from database");
    }
}