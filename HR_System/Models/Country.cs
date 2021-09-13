using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        /// <summary>
        /// Relations
        /// </summary>
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public List<Location> Locations { get; set; }
    }

}
