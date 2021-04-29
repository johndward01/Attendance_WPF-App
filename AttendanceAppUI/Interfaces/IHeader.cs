using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceAppUI
{
    public interface IHeader
    {
        public long MeetingID { get; set; }
        public string Topic { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string UserEmail { get; set; }
        public int DurationInMinutes { get; set; }
        public int TotalParticipants { get; set; }
    }
}
