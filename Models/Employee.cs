namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? JobTitle { get; set; }
        public decimal Salary { get; set; }
        public Rank Rank { get; set; }
        public string? Department { get; set; }
        public IList<Address>? Address { get; set; }
    }

    public class Address
    {
        public string? Street { get; set; }
        public string? Zone { get; set; }
        public long ZipCode { get; set; }
    }

    public enum Rank
    {
        Officer,
        Civilian,
        NonOfficer,
        OfficerCadet
    }
}
