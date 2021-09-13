using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_System.Models
{
    public class Region
    {
        public int Id{ get;set;}
        public string Name { get; set; }

        /// <summary>
        /// Relations
        /// </summary>
        public List<Country> Countries { get; set; }
    }
}
