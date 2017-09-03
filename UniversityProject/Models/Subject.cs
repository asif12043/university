using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{

    public enum SubjectType
    {
        Major,NonMajor
    }

    public class Subject
    {
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public SubjectType? SubjectType { get; set; }

        public ICollection<Course> Courses  { get; set; }


    }
}