using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AttendanceAppUI
{
    public class CSVParser
    {
        public 

        public IHeader PopulateHeader()
        {
            var list = new List<string>();
            var entireString = "";
            var files = Directory.EnumerateFiles(@"C:\Users\johnd\Desktop\Attendance", "*.csv");

            foreach (var file in files)
            {
                var sr = new StreamReader(file);
                var rawAttendanceString = sr.ReadToEnd();
                list.Add(rawAttendanceString);
            }

            File.WriteAllLines(@"C:\Users\johnd\Desktop\Attendance\Roster.txt", list);
        }
        
    }
}
