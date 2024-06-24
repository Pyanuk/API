using System;
using System.Collections.Generic;

namespace EMIAS_API.Models
{
    public partial class ResearchDocument
    {
        public int? IdAppointment { get; set; }
        public string NameResearchDocument { get; set; } = null!;
        public string Rtf { get; set; } = null!;

    }
}
