using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public string EnrollmentDate { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public virtual Student Student  { get; set; }

        public virtual Course Course { get; set; }

    }
}