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
    [Table("People")]
    public class People
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
		public List<ExperiencePeople> ExperiencePeople { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }

}
