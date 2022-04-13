using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models.EventRelations
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [Required, NotMapped]
        public IFormFile Photo { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }

    }
}
