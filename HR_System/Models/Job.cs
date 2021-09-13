using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float MinSalary { get; set; }
        public float MaxSalary { get; set; }
        /// <summary>
        /// Relations
        /// </summary>
        public List <Employee> Employees { get; set; }
        public List<Job_History> JobHistories { get; set; }



    }
}
