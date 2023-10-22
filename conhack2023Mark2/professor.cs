//nic
using System;
using System.Data.SqlTypes;

namespace conhack2023
{
    internal class professor
    {
        public SqlInt16 id;
        public string? password;
        public string? institution;
        public int lecturesRecorded;

        string professorToSQL()
        {
            return "";
        }
    }
}
