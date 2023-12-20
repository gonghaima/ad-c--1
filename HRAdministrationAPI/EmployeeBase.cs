namespace HRAdministrationAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Salary { get; set; }
    }
}

