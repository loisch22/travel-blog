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
    [Table("ExperiencePeople")]
    public class ExperiencePeople
    {
        [Key]
        public int ExperiencePeopleId { get; set; }
        public int ExperienceId { get; set; }
        public int PeopleId { get; set; }
        public Experience Experiences { get; set; }
        public People People { get; set; }
    }

}
