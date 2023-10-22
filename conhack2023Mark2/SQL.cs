//ethan
//justin
//nic
using System.Data.SqlClient;
using System;
using MySqlConnector;

namespace conhack2023
{
    internal class SQL
    {
        public string connectionString;
        public MySqlConnection connection;
        public MySqlCommand cmd;

        public SQL(string connectionString)
        {
            this.connectionString = connectionString;

            this.connection = new MySqlConnection();
            this.connection.ConnectionString = (connectionString);

            using var cmd = new MySqlCommand();
            this.cmd = cmd;
        }

        public void openConnection()
        {
            try
            {
                this.connection.Open();
                MessageBox.Show("database is connected");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void closeConnection()
        {
            try
            {
                this.connection.Close();
                MessageBox.Show("database is closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void createTables()
        {
            // create professor table
            this.cmd.CommandText = @"create table professor(
            pID smallint primary key not null, pPassword varchar(50), 
            pInstitution varchar(20), numOfLectures int)";
            this.cmd.ExecuteNonQuery();

            // create studnt table
            cmd.CommandText = @"create table student(
            sID smallint primary key not null, sPassword varchar(50), 
            lecturesWatched int);";
            this.cmd.ExecuteNonQuery();

            // create course table
            this.cmd.CommandText = @"create table course(
            cID smallint primary key not null, numOfLectures int, 
            sID smallint not null, pID smallint not null, startdate date, 
            enddate date, foreign key (sID) references student(sID), 
            foreign key (pID) references professor(pID));";
            this.cmd.ExecuteNonQuery();

            // create watched lecture table
            this.cmd.CommandText = @"create table watchedLectures
            (numOfLectures int primary key not null, sID smallint not null, 
            cID smallint not null, foreign key (sID) references student(sID), 
            foreign key (cID) references course(cID));";
            this.cmd.ExecuteNonQuery();

            // create lecture table
            this.cmd.CommandText = @"create table lectures
            (lID smallint primary key not null, lTitle varchar(20), 
            lDesc mediumtext, lDate varchar(15), lFileName varchar(30), 
            lDuration time, lAvailability tinyint);";
            this.cmd.ExecuteNonQuery();

            // create meeting table
            this.cmd.CommandText = @"create table meeting
            (mHost varchar(15) primary key not null, mParticipant varchar(25), 
            mTranscript mediumtext, mStart time, mEnd time);";
            this.cmd.ExecuteNonQuery();

            // create comments table
            this.cmd.CommandText = @"create table comments
            (comID smallint primary key not null, sID smallint not null, 
            cdateposted date, ctimestamp timestamp, 
            foreign key (sID) references student(sID));";
            this.cmd.ExecuteNonQuery();

            // create comments table
            this.cmd.CommandText = @"create table comments
            (comID smallint primary key not null, sID smallint not null, 
            cdateposted date, ctimestamp timestamp, 
            foreign key (sID) references student(sID));";
            this.cmd.ExecuteNonQuery();

            // create comment section table
            this.cmd.CommandText = @"create table commentSection
            (comID smallint not null, cID smallint not null, 
            foreign key (comID) references comments(comID), 
            foreign key (cID) references course(cID));";
            this.cmd.ExecuteNonQuery();
        }
    }
}
