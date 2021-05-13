using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceAppUI.Models
{
    public class Student
    {
        private int _totalMinutes = 0;

        // propfull
        private int _duration;

        public int Duration
        {
            get 
            { 
                return _duration;
            }
            set 
            {
                _duration = value;
                _totalMinutes += value;
            }
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string CourseTitle { get; set; }

        
        public double TotalHours()
        {
            return _totalMinutes / 60;
        }
    }
}
