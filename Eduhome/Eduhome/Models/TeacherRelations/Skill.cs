using System.Collections.Generic;
using EduHome.Models;

namespace EduHome.Models.TeacherRelations
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherSkill> TeacherSkills { get; set; }
    }
}
