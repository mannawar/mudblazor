using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new()
        {
            new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@lekhwiya.gov.qa", JobTitle = "Software Engineer", Salary = 60000 },
            new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@lekhwiya.gov.qa", JobTitle = "Project Manager", Salary = 75000 },
            new Employee { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@lekhwiya.gov.qa", JobTitle = "QA Engineer", Salary = 50000 },
            new Employee { EmployeeID = 4, FirstName = "Bob", LastName = "Williams", Email = "bob.williams@lekhwiya.gov.qa", JobTitle = "HR Manager", Salary = 55000 },
            new Employee { EmployeeID = 5, FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@lekhwiya.gov.qa", JobTitle = "DevOps Engineer", Salary = 70000 }
        };

        public List<Employee> GetEmployee() => employees;
    }
}
