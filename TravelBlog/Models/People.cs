using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TravelBlog.Models
{    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class People
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public int ExperienceId { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }

}
