using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Relations
        /// </summary>
        public Location Location { get; set; }
      //  public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }


    }
}
