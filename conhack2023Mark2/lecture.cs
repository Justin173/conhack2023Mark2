//justin
using static conhack2023.comment;
using System;
using System.Collections;
using System.Reflection;

namespace conhack2023
{
    internal class lecture
    {
        public lecture(string ti, string de, DateTime date, string file, float len, int avail, ArrayList comments)
        {
            string title = ti;
            string desc = de;
            DateTime dateRecorded = date;
            string mp4File = file;
            float length = len;
            int availability = avail;
            ArrayList commentSection = comments;
        }


        bool postLecture()
        {
            return true;
        }

        bool deleteLecture()
        {
            return true;
        }








        string lectureToSQL()
        {
            return "";
        }
    }
}
