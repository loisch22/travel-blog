using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TravelBlog.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public int PeopleId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<People> People { get; set; }
    }
}
