﻿using System;
using System.Collections.Generic;

namespace EMIAS_API.Models
{
    public partial class AppointmentDocument
    {
        public int? IdAppointment { get; set; }
        public string NameAppointmentDocument { get; set; } = null!;
        public string Rtf { get; set; } = null!;

    }
}
