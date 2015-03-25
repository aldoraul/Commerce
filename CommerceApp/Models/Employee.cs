using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//BA
using System.ComponentModel.DataAnnotations; //BA For setting the key to create the DBContext and controller
using System.ComponentModel.DataAnnotations.Schema;//BA

//BA
namespace CommerceApp.Models
{
    
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public virtual string firstName { get; set; }

        public virtual string lastName { get; set; }

        
        
        
        public virtual string jobTitle { get; set; }

        public virtual DateTime birthDate { get; set; }

        public virtual DateTime hireDate { get; set; }

        public virtual int daysFirstCall { get; set; }

        public virtual int daysSecondCall { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}