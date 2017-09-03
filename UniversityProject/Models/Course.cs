using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public int SubjectId { get; set; }

        public string Name { get; set; }

        public decimal Duration { get; set; }

        public string Description { get; set; }

        public int  TutorId { get; set; }

        public virtual Tutor Tutor { get; set; }

        public virtual Subject Subject  { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}