using AttendanceAppUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceAppUI.Classes
{
    public static class ZoomAttendanceReport
    {
        public static List<string> DistinctUsers { get; set; } = new List<string>();
        public static Dictionary<IHeader, ICSV_Data> Meetings { get; set; }

        public static int GetTotalDaysInClass()
        {
            throw new NotImplementedException();
        }

        public static string GetClassTopic()
        {
            throw new NotImplementedException();
        }




    }
}
