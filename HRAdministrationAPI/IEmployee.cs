using System;
namespace HRAdministrationAPI
{
	public interface IEmployee
	{
		 int Id { get; set; }
		 string FirstName { get; set; }
		 string LastName { get; set; }
         public decimal Salary { get; }

    }
}

