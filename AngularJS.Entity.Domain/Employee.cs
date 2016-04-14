using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJS.Entity.Domain
{
    public class Employee
    {
        public int EmployeeId
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
     
        public string Description
        {
            get;
            set;
        }
        public decimal? Salary { get; set; }
  
        public string Country
        {
            get;
            set;
        }
      
        public string State
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }
    }
}
