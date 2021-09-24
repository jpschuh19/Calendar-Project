using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

namespace CalendarProject
{
    public class Event
    {
        private int eventID, eventLength;
        private string eventTime;
        private string eventName, eventDescription, eventDate;
        Random rand = new Random();

        public Event(string name, string desc, string time, string date, int length, int id)
        {
            eventID = id;
            eventName = name;
            eventDescription = desc;
            eventTime = time;
            eventDate = date;
            eventLength = length;
        }

        public void saveEvent(int calID)
        {
            eventID = rand.Next(1000000000);

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO cadenjacobjamesevent (eventID, calendarID, eventDate, eventTime, eventLength, eventName, eventDescription) VALUES (@id, @calID, @date, @time, @length, @name, @desc)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", eventID);
                cmd.Parameters.AddWithValue("@calID", calID);
                cmd.Parameters.AddWithValue("@date", eventDate);
                cmd.Parameters.AddWithValue("@time", eventTime);
                cmd.Parameters.AddWithValue("@length", eventLength);
                cmd.Parameters.AddWithValue("@name", eventName);
                cmd.Parameters.AddWithValue("@desc", eventDescription);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }

        public void deleteEvent()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
                string sql = "DELETE FROM cadenjacobjamesevent WHERE eventID=@eventID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eventID", eventID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public int getEventID()
        {
            return eventID;
        }

        public void setEventID(int id)
        {
            eventID = id;
        }

        public string getEventTime()
        {
            return eventTime;
        }

        public void setEventTime(string time)
        {
            eventTime = time;
        }

        public String getEventDate()
        {
            return eventDate;
        }

        public void setEventDate(string date)
        {
            eventDate = date;
        }

        public String getEventName()
        {
            return eventName;
        }

        public void setEventName(string name)
        {
            eventName = name;
        }

        public String getEventDescription()
        {
            return eventDescription;
        }

        public void setEventDescription(string description)
        {
            eventDescription = description;
        }

        public int getEventLength()
        {
            return eventLength;
        }

        public void setEventLength(int length)
        {
            eventLength = length;
        }


        public void updateEventData()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
                string sql = "UPDATE cadenjacobjames SET eventDate=@date, eventLength=@length, eventTime=@startTime, eventName=@name, eventDescription=@description, WHERE eventID=@eventID;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);
                cmd.Parameters.AddWithValue("@length", eventLength);
                cmd.Parameters.AddWithValue("@startTime", eventTime);
                cmd.Parameters.AddWithValue("@name", eventName);
                cmd.Parameters.AddWithValue("@description", eventDescription);
                cmd.Parameters.AddWithValue("@eventID", eventID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public ArrayList retrieveEvents()
        {
            ArrayList eventList = new ArrayList();
            //ArrayList eventList = new ArrayList();  //a list to save the events
            //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM cadenjacobjamesevent ORDER BY eventDate ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)
            {
                

                string name = row["eventName"].ToString();
                string desc = row["eventDescription"].ToString();
                string time = row["eventTime"].ToString();
                string date = row["eventDate"].ToString();

                int length = Int32.Parse(row["eventLength"].ToString());
                int id = Int32.Parse(row["eventID"].ToString());

                Event newEvent = new Event(name, desc, time, date, length, id);

                eventList.Add(newEvent);
            }
            Console.WriteLine("*********" + eventList.Count);
            return eventList;  //return the event list

        }
    }
}