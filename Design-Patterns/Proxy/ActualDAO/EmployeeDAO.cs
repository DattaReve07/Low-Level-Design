namespace Proxy.ActualDAO;

public interface EmployeeDAO
{
    public string GetEmployeeName(int employeeId);

    public void AddEmployee(string employeeName);

    public void DeleteEmployee(int employeeId);
}