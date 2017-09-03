using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
    public enum TypeOfPosition
    {
        Professor,Assistent_Professor,Lecturer
    }
    
    public class Tutor
    {
        public int TutorId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public Gender? Gender { get; set; }

        public TypeOfPosition? TypeOfPosition { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}