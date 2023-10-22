//nic
using System;

namespace conhack2023
{
    internal class meeting
    {
        public professor? host;
        public List<student> participant = new List<student>();
        public string? transcript;
        public DateTime startTime;
        public DateTime endTime;

        public void scheduleMeeting()
        {
            Console.WriteLine("Input start date and time for the meeting:");
            this.startTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Input end date and timer for the meeting:");
            this.endTime = Convert.ToDateTime(Console.ReadLine());
        }

        public void initializeMeeting()
        {

        }

        public void finishMeeting(lecture lecture)
        {
            string filename = Console.ReadLine();
            saveToLecture(filename);
        }

        public void saveToLecture(string filename)
        {

        }

        string meetingToSQL()
        {
            return "";
        }
    }
}
