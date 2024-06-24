using System;
using System.Collections.Generic;

namespace EMIAS_API.Models
{
    public partial class Speciality
    {

        public int? IdSpeciality { get; set; }
        public string SpecialityName { get; set; } = null!;
        public string ImagePath { get; set; } = null!;


    }
}
