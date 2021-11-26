using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceAppUI.Models
{
    public class AttendanceReport
    {
        public string[] Staff = { "Seth Bowman", "Denise Shines", "Jeremy Huddleston", "Michael Doyle", "John Ward", "Cruz Sanchez" };
        public string[] Names { get; set; }
        public string[] User_Emails { get; set; }
        public int[] Total_Durations { get; set; }
    }
}
