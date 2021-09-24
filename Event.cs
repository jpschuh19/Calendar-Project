using System;

public class Event
{
    public Event()
    {
        int eventID, eventDate, eventLength;
        double eventTime;
        string eventName, eventDescription;
    }
    void saveEvent()
    {

    }

    void deleteEvent()
    {

    }

    int getEventID()
    {

    }

    double getEventTime()
    {

    }



    private void updateEventData()
    {
        string connStr = "server=######;user=#######;database=#######;port=######;password=#######;";
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
            string sql = "UPDATE Event SET eventDate=@date, eventLength = @length, eventTime = @startTime, eventName = @name, eventDescription = @description, WHERE eventID=@eventID;";
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

    public static ArrayList retrieveEvents(int id)
    {
        ArrayList eventList = new ArrayList();
        //ArrayList eventList = new ArrayList();  //a list to save the events
        //prepare an SQL query to retrieve all the events on the same, specified date
        DataTable myTable = new DataTable();
        string connStr = "server =######;user=#######;database=#######;port=######;password=#######;";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            string sql = "SELECT * FROM eventCalendar ORDER BY date ASC";
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
            Event newEvent = new Event();

            newEvent.eventID = Int32.Parse(row["eventID"].ToString());
            newEvent.eventDate = (row["eventDate"].ToString());
            newEvent.eventName = row["name"].ToString();
            newEvent.eventTime = Int32.Parse(row["startTime"].ToString());
            newEvent.eventLength = Int32.Parse(row["Length"].ToString());
            newEvent.eventDescription = row["eventDescription"].ToString();
                
            accountList.Add(newEvent);
        }
        Console.WriteLine("*********" + eventList.Count);
        return eventList;  //return the event list
    }
}
