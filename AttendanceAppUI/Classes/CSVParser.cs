using AttendanceAppUI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAppUI
{
    public class CSVParser
    {

        public async Task<IHeader> PopulateHeader(string path)
        {
            var file = await File.ReadAllLinesAsync(path);
            var zoomHeader = new ZoomHeader()
            {
                MeetingID = long.Parse(file[7]),
                Topic = file[8],
                StartTime = file[9],
                EndTime = file[10],
                UserEmail = file[11],
                DurationInMinutes = int.Parse(file[12]),
                TotalParticipants = int.Parse(file[13]),
            };

            return zoomHeader;
        }

        public async Task<List<ICSV_Data>> PopulateCSVDataList(string path)
        {
            var file = await File.ReadAllLinesAsync(path);
            var dataList = new List<ICSV_Data>();
            var names = new List<string>();
            var emails = new List<string>();
            var totals = new List<int>();
            var guestConditionals = new List<bool>();            
            int nameIndex = 18; // 18 should be the index number of the first field that is relevant (i.e. John Smith)
            int emailIndex = 19;
            int totalIndex = 20;
            int isGuestIndex = 21;

            for (int i = 18; i < file.Length; i++)
            {
                names.Add(file[nameIndex]);
                emails.Add(file[emailIndex]);
                totals.Add(int.Parse(file[totalIndex]));
                guestConditionals.Add(bool.Parse(file[isGuestIndex]));
                nameIndex++; emailIndex++; totalIndex++; isGuestIndex++;
            }
            #region refactored code to above ⬆⬆
            //for (int i = 18; i < file.Length; i+=4)
            //{
            //    names.Add(file[i]);
            //}

            //for (int i = 19; i < file.Length; i += 4)
            //{
            //    emails.Add(file[i]);
            //}

            //for (int i = 20; i < file.Length; i += 4)
            //{
            //    totals.Add(int.Parse(file[i]));
            //}

            //for (int i = 21; i < file.Length; i += 4)
            //{
            //    guestConditionals.Add(bool.Parse(file[i]));
            //}
            #endregion

            for (int i = 0; i < names.Count; i++)
            {
                var zoomData = new ZoomCSVData
                {
                    Name = names[i],
                    UserEmail = emails[i],
                    TotalDurationInMinutes = totals[i],
                    IsGuest = guestConditionals[i]
                };
                dataList.Add(zoomData);
            }

            return dataList;
        }

    }
}
