using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercises.Models.Data
{
    public class State
    {

        public string StateAbbreviation { get; set; }
        [Required(ErrorMessage = "You must enter a state")]
        public string StateName { get; set; }
    }
}