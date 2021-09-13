using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Job_History
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
         /// <summary>
         /// Relations
         /// </summary>
        public Employee Employee { get; set; }
        public Job Job { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }



    }
}
