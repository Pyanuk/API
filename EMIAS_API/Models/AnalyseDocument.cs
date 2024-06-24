using System;
using System.Collections.Generic;

namespace EMIAS_API.Models
{
    public partial class AnalyseDocument
    {
        public int? IdAppointment { get; set; }
        public string NameAnalyseDocument { get; set; } = null!;
        public string Rtf { get; set; } = null!;

    }
}
