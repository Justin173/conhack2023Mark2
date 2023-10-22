//justin
using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;

namespace conhack2023
{
    internal class comment
    {
        public comment(string acc, string para, DateTime date, bool hasStamp, uint stamp)
        {
            string account = acc;
            string paragraph = para;
            DateTime datePosted = date;
            bool hasTimeStamp = hasStamp;
            uint timeStamp = stamp;
        }

        bool postComment()
        {
            return true;
        }

        bool editComment()
        {
            return true;
        }

        bool deleteComment()
        {
            return true;
        }


        //comment getComment()
        //{
        //    return comment;
        //}


        public string commentToSQL()
        {
            return "";
        }

    }

}
