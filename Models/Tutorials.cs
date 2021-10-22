using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class Tutorials
    {
        public int StudentId { get; set; } // hidden field
        public string StudentName { get; set; } // Text Box
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public DateTime DoB { get; set; }
        public Gender StudentGender { get; set; } // dropdown
        public string GenderRadioMale { get; set; } // radio
        public string GenderRadioFemale { get; set; } // radio
        public bool isActive { get; set; } // checkbox
        public string Description { get; set; } // Text Area
        public string Password { get; set; }
        public string StudentSubject { get; set; }

    }

    // Enumerable Options for StudentGender dropdown list
    public enum Gender
    {
        Male,
        Female
    }
}
