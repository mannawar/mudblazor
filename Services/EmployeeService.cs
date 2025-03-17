using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new()
        {
            new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@lekhwiya.gov.qa", JobTitle = "Software Engineer", Salary = 60000, Rank=Rank.Civilian, Department="IT", Address = new List<Address>{ new Address {Street = "23", Zone= "71", ZipCode = 12345 }}},
            new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@lekhwiya.gov.qa", JobTitle = "Lieutenant", Salary = 75000, Rank=Rank.Officer, Department="HR", Address = new List<Address>{ new Address {Street = "51", Zone= "67", ZipCode = 24039 }}},
            new Employee { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@lekhwiya.gov.qa", JobTitle = "Major", Salary = 80000, Rank=Rank.Officer, Department="General Administration", Address = new List<Address>{ new Address {Street = "49", Zone= "58", ZipCode = 23456 }}},
            new Employee { EmployeeID = 4, FirstName = "Bob", LastName = "Williams", Email = "bob.williams@lekhwiya.gov.qa", JobTitle = "Officer Cadet", Salary = 55000, Rank=Rank.NonOfficer, Department="Public Relation", Address = new List<Address>{ new Address {Street = "12", Zone= "45", ZipCode = 34567 }} },
            new Employee { EmployeeID = 5, FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@lekhwiya.gov.qa", JobTitle = "DevOps Engineer", Salary = 70000, Rank=Rank.NonOfficer, Department="Finance", Address = new List<Address>{ new Address {Street = "20", Zone= "30", ZipCode = 45678 }} }
        };

        public List<Employee> GetEmployee() => employees;
    }
}
