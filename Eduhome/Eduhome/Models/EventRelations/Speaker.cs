﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models.EventRelations
{
    public class Speaker:BaseEntity
    {
        public string Name { get; set; }

        public string Occupation { get; set; }
        public string Image { get; set; }
        [Required, NotMapped]
        public IFormFile Photo { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
