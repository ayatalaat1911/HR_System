using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        /// <summary>
        /// Relations
        /// </summary>
        public Country Country { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public List<Department>Departments { get; set; }
    }
}
