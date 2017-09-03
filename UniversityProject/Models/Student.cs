using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProject.Models
{
   
    public enum StudentResidentType
    {
        Residential ,NonResidential
    }
    public class Student
    {
        public int StudentId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public  string DateOfBirth { get; set; }

        public DateTime? RegistrationDate  { get; set; }

        public DateTime? lastLoginDate { get; set; }

        public Gender? Gender { get; set; }

        public StudentResidentType? StudentResidentType { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}