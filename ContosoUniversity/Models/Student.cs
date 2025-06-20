using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First and Mid Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy MMMM dd}")]
        public DateTime EnrollmentDate { get; set; }

        public string Secret { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}