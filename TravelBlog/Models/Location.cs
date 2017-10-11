using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
        public Location()
        {
            this.Experiences = new HashSet<Experience>();
            this.People = new HashSet<People>();
        }

        [Key]
        public int LocationId { get; set; }
        public string LocationCountry { get; set; }
        public string LocationCity { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
