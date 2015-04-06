using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommerceApp.Models
{
    public class EmployeeSchedule
    {
        public IList<EmployeeWorkSchedule> GetEmployeeSchedule()
        {
            var list =  new List<EmployeeWorkSchedule>();

            list.Add
                (
                    new EmployeeWorkSchedule
                    {
                        ID = 1,
                        Title = String.Format("Manager"),
                        Start = DateTime.Now.AddDays(0),
                        End = DateTime.Now.AddDays(6),
                        color = String.Format("green")
                    }
                    );


            return list;
        }
    }
}