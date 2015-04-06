using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//BA
using System.ComponentModel.DataAnnotations; //BA For setting the key to create the DBContext and controller
using System.ComponentModel.DataAnnotations.Schema;//BA
using System.ComponentModel;//BA used to change display name of employee attributes
//BA

    public class SchedulePeroid
    {
        [Key]
        public DateTime scheduleStart { get; set; }
       [ForeignKey("Employee")]
        [Column(Order = 1)]
        public int EmployeeID { get; set; }
        public string jobName { get; set; }
       
        public DateTime scheduleEnd { get; set; } // should be 1 week periods except vacation, training, military leave etc.
        public string statusColor { get; set; }
        public string statusClass { get; set; }

        public virtual List<SchedulePeroid> SchedulePeriods { get; set; }
    }
