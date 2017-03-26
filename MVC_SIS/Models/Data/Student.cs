using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercises.Models.Data
{
    
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "You must enter a First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must enter a Last Name")]
        public string LastName { get; set; }
        public decimal GPA { get; set; }
        public Address Address { get; set; }
        public Major Major { get; set; }
        public List<Course> Courses { get; set; }
    }
}