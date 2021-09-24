using System;

public class itsCalendar
{
    int calendarID, numEvents;
    public itsCalendar()
    {

    }

    void createEvent()
    {
        string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
            string sql = "UPDATE cadenjacobjames SET numEvents=numEvents+1 WHERE calendarID=@calendarID;";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@eventID", calendarID);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        conn.Close();
        Console.WriteLine("Done.");
    }
        
    void deleteEvent()
    {
        string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            //string sql = "INSERT INTO changstudent (id, name) VALUES (@uid, @uname)";
            string sql = "UPDATE cadenjacobjames SET numEvents=numEvents-1 WHERE calendarID=@calendarID;";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@eventID", calendarID);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        conn.Close();
        Console.WriteLine("Done.");
    }

    void viewEvent()
    {

    }

    void monthlyEventList()
    {

    }

    void managerCoordinateMeeting()
    {

    }

    bool checkTimeConflict() //return true if there's no time conflict
    {
        if (false) //some condition
        {
            return false; //return false if there is a time conflict
        }

        return true;
    }

    void sendErrorMessage()
    {

    }
	
}
