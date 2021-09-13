using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public float Salary { get; set; }
        public float Commission { get; set; }
        /// <summary>
        /// Relations
        /// </summary>
        public List<Job_History> JobHistories { get; set; }
        public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }
        public int ManagerId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Job Job { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }


    }
}
