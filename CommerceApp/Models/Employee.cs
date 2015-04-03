using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//BA
using System.ComponentModel.DataAnnotations; //BA For setting the key to create the DBContext and controller
using System.ComponentModel.DataAnnotations.Schema;//BA
<<<<<<< HEAD
using System.ComponentModel;//BA used to change display name of employee attributes
=======
using System.ComponentModel;

>>>>>>> 6f1da6a55f134eaf430ad7d056ba60b52c4fdd76
//BA
namespace CommerceApp.Models
{
    
    public class Employee
    {
        [Key]

        public int EmployeeID { get; set; }

        [DisplayName("First Name")]
        public virtual string firstName { get; set; }

        [DisplayName("Last Name")]
        public virtual string lastName { get; set; }

        
        
        [DisplayName("Job Title")]
        public virtual string jobTitle { get; set; }

<<<<<<< HEAD
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd yyyy}", ApplyFormatInEditMode = true)]
        
        [DisplayName("Birth Date")]
        public virtual DateTime birthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd yyyy}", ApplyFormatInEditMode = true)]

=======
        [DisplayName("Birth Date")]
        public virtual DateTime birthDate { get; set; }

>>>>>>> 6f1da6a55f134eaf430ad7d056ba60b52c4fdd76
        [DisplayName("Hire Date")]
        public virtual DateTime hireDate { get; set; }

        [DisplayName("Days First Call")]
        public virtual int daysFirstCall { get; set; }

        [DisplayName("Days Second Call")]
        public virtual int daysSecondCall { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual List<Employee> Employees { get; set; }

    }
}