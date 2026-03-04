// See https://aka.ms/new-console-template for more information

using Proxy.ActualDAO;
using Proxy.Proxy;

Console.WriteLine("Proxy Design Pattern Example");

// Create the real object
var realObject = new EmployeeDaoImpl();
EmployeeDAO adminDao = new EmployeeDaoProxy(realObject, AccessRoles.ADMIN);
EmployeeDAO userDao = new EmployeeDaoProxy(realObject, AccessRoles.USER);

// User operations
Console.WriteLine("\n== User Operations ==\n");
try
{
    Console.WriteLine("User trying to get employee name:");
    Console.WriteLine(userDao.GetEmployeeName(1));

    Console.WriteLine("User trying to add employee:");
    userDao.AddEmployee("Jane Doe");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}

// Admin operations
Console.WriteLine("\n== Admin Operations ==\n");
try
{
    Console.WriteLine("Admin trying to get employee name:");
    Console.WriteLine(adminDao.GetEmployeeName(1));

    Console.WriteLine("Admin trying to add employee:");
    adminDao.AddEmployee("Jane Doe");

    Console.WriteLine("Admin trying to delete employee:");
    adminDao.DeleteEmployee(1);
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}

