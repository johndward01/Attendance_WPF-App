using AttendanceAppUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceAppUI
{
    public class ZoomCSVData : ICSV_Data
    {
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public int TotalDurationInMinutes { get; set; }
        public bool IsGuest { get; set; }

    }
}
