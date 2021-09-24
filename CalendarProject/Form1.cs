using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarProject
{
    public partial class Form1 : Form
    {
        ArrayList eventList = new ArrayList();
        Event newEvent = new Event("","","","",0,0);
        User currentUser = new User(1);
        itsCalendar newCalendar = new itsCalendar();
        


        public Form1()
        {
            InitializeComponent(); //hope this works
            eventList = newEvent.retrieveEvents();
            textBoxMonthCalendar.Text = "5";
            textBoxYearCalendar.Text = "2021";
            panelCalendar.BringToFront();
        }

        #region putEventsOnCalendar
        public void eventsOnCalendar()
        {

            int year = int.Parse(textBoxYearCalendar.Text);
            int month = int.Parse(textBoxMonthCalendar.Text);
            for (int i = 0; i < eventList.Count; i++)
            {
                Event currentEvent = new Event("", "", "", "", 0, 0);
                currentEvent = (Event)eventList[i];
                if (int.Parse(currentEvent.getEventDate().Substring(5, 2)) == month)
                {
                    if (int.Parse(currentEvent.getEventDate().Substring(0, 4)) == year)
                    {
                        int case_switch = int.Parse(currentEvent.getEventDate().Substring(8, 2));
                        switch (case_switch)
                        {
                            case 1:
                                listBox1.Items.Add(currentEvent.getEventName());
                                break;
                            case 2:
                                listBox2.Items.Add(currentEvent.getEventName());
                                break;
                            case 3:
                                listBox3.Items.Add(currentEvent.getEventName());
                                break;
                            case 4:
                                listBox4.Items.Add(currentEvent.getEventName());
                                break;
                            case 5:
                                listBox5.Items.Add(currentEvent.getEventName());
                                break;
                            case 6:
                                listBox6.Items.Add(currentEvent.getEventName());
                                break;
                            case 7:
                                listBox7.Items.Add(currentEvent.getEventName());
                                break;
                            case 8:
                                listBox8.Items.Add(currentEvent.getEventName());
                                break;
                            case 9:
                                listBox9.Items.Add(currentEvent.getEventName());
                                break;
                            case 10:
                                listBox10.Items.Add(currentEvent.getEventName());
                                break;
                            case 11:
                                listBox11.Items.Add(currentEvent.getEventName());
                                break;
                            case 12:
                                listBox12.Items.Add(currentEvent.getEventName());
                                break;
                            case 13:
                                listBox13.Items.Add(currentEvent.getEventName());
                                break;
                            case 14:
                                listBox14.Items.Add(currentEvent.getEventName());
                                break;
                            case 15:
                                listBox15.Items.Add(currentEvent.getEventName());
                                break;
                            case 16:
                                listBox16.Items.Add(currentEvent.getEventName());
                                break;
                            case 17:
                                listBox17.Items.Add(currentEvent.getEventName());
                                break;
                            case 18:
                                listBox18.Items.Add(currentEvent.getEventName());
                                break;
                            case 19:
                                listBox19.Items.Add(currentEvent.getEventName());
                                break;
                            case 20:
                                listBox20.Items.Add(currentEvent.getEventName());
                                break;
                            case 21:
                                listBox21.Items.Add(currentEvent.getEventName());
                                break;
                            case 22:
                                listBox22.Items.Add(currentEvent.getEventName());
                                break;
                            case 23:
                                listBox23.Items.Add(currentEvent.getEventName());
                                break;
                            case 24:
                                listBox24.Items.Add(currentEvent.getEventName());
                                break;
                            case 25:
                                listBox25.Items.Add(currentEvent.getEventName());
                                break;
                            case 26:
                                listBox26.Items.Add(currentEvent.getEventName());
                                break;
                            case 27:
                                listBox27.Items.Add(currentEvent.getEventName());
                                break;
                            case 28:
                                listBox28.Items.Add(currentEvent.getEventName());
                                break;
                            case 29:
                                listBox29.Items.Add(currentEvent.getEventName());
                                break;
                            case 30:
                                listBox30.Items.Add(currentEvent.getEventName());
                                break;
                            case 31:
                                listBox31.Items.Add(currentEvent.getEventName());
                                break;
                            default:
                                break;

                        }
                    }
                }
            }
        }
        #endregion

        #region delete events on Calendar

        public void deleteEventsOnCalendar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox11.Items.Clear();
            listBox12.Items.Clear();
            listBox13.Items.Clear();
            listBox14.Items.Clear();
            listBox15.Items.Clear();
            listBox16.Items.Clear();
            listBox17.Items.Clear();
            listBox18.Items.Clear();
            listBox19.Items.Clear();
            listBox20.Items.Clear();
            listBox21.Items.Clear();
            listBox22.Items.Clear();
            listBox23.Items.Clear();
            listBox24.Items.Clear();
            listBox25.Items.Clear();
            listBox26.Items.Clear();
            listBox27.Items.Clear();
            listBox28.Items.Clear();
            listBox29.Items.Clear();
            listBox30.Items.Clear();
            listBox31.Items.Clear();

        }

        #endregion

        #region calendar buttons
        /*
         * panelCalendar MAIN SCREEN
         */
        private void buttonNewEvent_Click(object sender, EventArgs e)
        {
            panelAddEvent.Visible=true;
            panelCalendar.Visible=false;

        }

        private void button1_Click(object sender, EventArgs e)//generate calendar data
        {
            deleteEventsOnCalendar();
            eventsOnCalendar();
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            panelDeleteEvent.Visible = true;
            panelCalendar.Visible = false;
        }

        private void buttonEditEvent_Click(object sender, EventArgs e)
        {
            panelEditEventSearch.Visible = true;
            panelCalendar.Visible = false;

        }

        private void buttonViewEvent_Click(object sender, EventArgs e)
        {
            panelViewEventByDate.Visible = true;
            panelCalendar.Visible = false;

        }

        private void buttonEventList_Click(object sender, EventArgs e)
        {
            panelViewEventList.Visible = true;
            panelCalendar.Visible = false;
        }

        private void buttonCreateMeeting_Click(object sender, EventArgs e)
        {
            panelCreateMeeting.Visible = true;
            panelCalendar.Visible = false;
        }
        #endregion

        #region add event
        /*
         * panelAddEvent
         */
        private void buttonAddEventDone_Click(object sender, EventArgs e)
        {
            //newEvent.saveEvent(1);//1 is the calendar id
            newEvent.setEventName(textBoxAddEventTitle.Text);
            newEvent.setEventDate(textBoxAddEventDate.Text);
            newEvent.setEventTime(textBoxAddEventStartTime.Text);
            newEvent.setEventDescription(textBoxAddEventDescription.Text);
            if (textBoxAddEventEndTime.Text != null) { newEvent.setEventLength(int.Parse(textBoxAddEventEndTime.Text)); }
            newEvent.setEventID(eventList.Count+1);
            newEvent.saveEvent(1);//1 is the calendar id
            eventList = newEvent.retrieveEvents();

            textBoxAddEventTitle.Text = "";
            textBoxAddEventDate.Text = "";
            textBoxAddEventStartTime.Text = "";
            textBoxAddEventDescription.Text = "";
            textBoxAddEventEndTime.Text = "";

        }

        private void buttonAddEventCancel_Click(object sender, EventArgs e)
        {
            panelAddEvent.Visible = false;
            panelCalendar.Visible = true;
        }

        private void textBoxAddEventTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddEventDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddEventStartTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddEventEndTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddEventDescription_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region view event list
        /*
         * panelViewEventList
         * This one is for entering the month and year
         */
        private void buttonViewEventListGo_Click(object sender, EventArgs e)
        {
            eventList = newEvent.retrieveEvents();

            if (textBoxViewEventListYear.Text.Length >= 4 && comboBoxViewEventList.SelectedIndex >= 0)
            {
                int year = int.Parse(textBoxViewEventListYear.Text);
                int month = (int)comboBoxViewEventList.SelectedIndex;
                labelEventListTop.Text = (month + 1).ToString() + " " + year.ToString();
                for (int i = 0; i < eventList.Count; i++)
                {
                    Event currentEvent = new Event("","","","",0,0);
                    currentEvent = (Event)eventList[i];
                    //listBoxEventList.Items.Add(month);
                    //listBoxEventList.Items.Add(year);
                    if (int.Parse(currentEvent.getEventDate().Substring(5, 2)) == month+1)
                    {
                        if (int.Parse(currentEvent.getEventDate().Substring(0, 4)) == year)
                        {
                            listBoxEventList.Items.Add(((Event)eventList[i]).getEventName());
                        }
                    }
                }
                panelEventList.Visible = true;
                panelViewEventList.Visible = false;
            }
        }
        private void buttonEventListCancel_Click_1(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelEventList.Visible = false;
        }

        private void buttonViewEventListCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelViewEventList.Visible = false;
        }

        private void comboBoxViewEventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = (int)comboBoxViewEventList.SelectedIndex;
        }

        private void textBoxViewEventListYear_TextChanged(object sender, EventArgs e)
        {
            if (textBoxViewEventListYear.Text.Length > 3)
            {
                int year = int.Parse(textBoxViewEventListYear.Text);
            }
        }
        #endregion

        #region event list
        /*
         * panelEventList
         * This one is for displaying the actual list itself
         */
        private void listBoxEventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEventListCancel_Click(object sender, EventArgs e)
        {
            listBoxEventList.Items.Clear();
            panelCalendar.Visible = true;
            panelEventList.Visible = false;
        }
        #endregion

        #region display event
        /*
         * panelDisplayEvent
         */
        private void buttonDisplayEventDone_Click(object sender, EventArgs e)
        {
            panelDisplayEvent.Visible = false;
            panelCalendar.Visible = true;
        }

        private void textBoxDisplayEventDescription_TextChanged(object sender, EventArgs e)
        {
            //nothing happens(database values aren't changed)
        }


        #endregion

        #region view event by date
        /*
         * panelViewEventByDate
         */
        private void listBoxViewEventByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxViewEventByDate.SelectedIndex < 0)
            {
                //if they select the textbox but outside one of the events
            }
            else
            {
                newEvent = (Event)eventList[listBoxViewEventByDate.SelectedIndex];
                labelDisplayEventTitle.Text = newEvent.getEventName();
                labelDisplayEventDate.Text = newEvent.getEventDate();
                labelDisplayEventStartEndTime.Text = newEvent.getEventTime().ToString();
                labelDisplayEventLength.Text = newEvent.getEventLength().ToString();
                textBoxDisplayEventDescription.Text = newEvent.getEventDescription();
                panelViewEventByDate.Visible = false;
                panelDisplayEvent.Visible = true;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBoxViewEventByDate.Items.Clear();
            foreach (Event ev in eventList)
            {
                listBoxViewEventByDate.Items.Add(((Event)ev).getEventName());
            }            
        }

        private void buttonViewEventByDateCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelViewEventByDate.Visible = false;
        }
        #endregion

        #region edit event
        #region edit event search
        /*
         * panelEditEventSearch
         */
        private void comboBoxEditEventSearchMonth_SelectedIndexChanged(object sender, EventArgs e) //this combobox is for searching months
        {
            //selectedEvent = comboBoxEditEventSearchMonth.SelectedItem;
        }

        private void listBoxEditEventSearch_SelectedIndexChanged(object sender, EventArgs e) //called when user selects an event from the list
        {
            if (listBoxEditEventSearch.SelectedItem != null) //important to write everything inside this if; user is capable of selecting nothing and we don't want that
            {
                newEvent = (Event)eventList[listBoxEditEventSearch.SelectedIndex];
                textBoxEditEventTitle.Text = newEvent.getEventName();
                textBoxEditEventDate.Text = newEvent.getEventDate();
                textBoxEditEventStartTime.Text = newEvent.getEventTime().ToString();
                textBoxEditEventDescription.Text = newEvent.getEventDescription();
                panelEditEvent.Visible = true;
                panelEditEventSearch.Visible = false;
                
            }
        }

        private void textBoxEditEventSearchYear_TextChanged(object sender, EventArgs e)
        {
            listBoxDeleteEvent.Items.Clear();
            if (textBoxEditEventSearchYear.Text.Length == 4)
            {
                foreach (Event ev in eventList)
                {
                    listBoxEditEventSearch.Items.Add(((Event)ev).getEventName());
                }

            }
        }

        private void buttonEditEventSearchCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelEditEventSearch.Visible = false;
        }
        #endregion
        #region edit event changes panel
        /*
         * panelEditEvent
         */
        private void textBoxEditEventTitle_TextChanged(object sender, EventArgs e) //new title
        {
            
        }

        private void textBoxEditEventDate_TextChanged(object sender, EventArgs e) //new date
        {

        }

        private void textBoxEditEventStartTime_TextChanged(object sender, EventArgs e) //
        {

        }

        private void textBoxEditEventEndTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditEventDone_Click(object sender, EventArgs e)
        {
            newEvent.setEventDate(textBoxEditEventDate.Text);
            newEvent.setEventName(textBoxEditEventTitle.Text);
            newEvent.setEventDescription(textBoxEditEventDescription.Text);
            newEvent.setEventTime (textBoxEditEventStartTime.Text);
            if (textBoxEditEventEndTime.Text != null) { newEvent.setEventLength(int.Parse(textBoxEditEventEndTime.Text)); }
            newEvent.updateEventData();
            panelCalendar.Visible = true;
            panelEditEvent.Visible = false;
        }
        
        private void buttonEditEventCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelEditEvent.Visible = false;
        }




        #endregion

        #endregion

        #region delete event
        /*
         * panelDeleteEvent
         */
        private void buttonDeleteEventDone_Click(object sender, EventArgs e)
        {
            if (newEvent != null && listBoxDeleteEvent.SelectedIndex >= 0) 
            { 
                newEvent = (Event)eventList[listBoxDeleteEvent.SelectedIndex]; 
                newEvent.deleteEvent();//deletes from DB
                eventList.Remove(newEvent);//deletes from array
            }
            listBoxDeleteEvent.Items.Clear();

            foreach (Event ev in eventList)
            {
                listBoxDeleteEvent.Items.Add(((Event)ev).getEventName());
            }

            
            
        }

        private void buttonDeleteEventCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelDeleteEvent.Visible = false;
        }

        private void comboBoxDeleteEventMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDeleteEventYear_TextChanged(object sender, EventArgs e)
        {
            listBoxDeleteEvent.Items.Clear();
            if (textBoxDeleteEventYear.Text.Length == 4)
            {
                foreach (Event ev in eventList)
                {
                    listBoxDeleteEvent.Items.Add(((Event)ev).getEventName());
                }

            }
        }

        private void listBoxDeleteEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region create meeting
        /*
         * panelCreateMeeting
         */
        private void buttonCreateMeetingDone_Click(object sender, EventArgs e)
        {
            newEvent.setEventName("meeting with user:" + currentUser.getID().ToString());
            newEvent.setEventDate(textBoxCreateMeetingDate.Text);
            newEvent.setEventLength(int.Parse(textBoxCreateMeetingLength.Text));

            textBoxCreateMeetingDate.Text = "";
            textBoxCreateMeetingLength.Text = "";
            textBoxCreateMeetingMemberIDs.Text = "";
        }

        private void buttonCreateMeetingCancel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = true;
            panelCreateMeeting.Visible = false;
        }

        private void textBoxCreateMeetingDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCreateMeetingLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCreateMeetingMemberIDs_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region misc
        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDisplayEvent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelViewEventByDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEditEventSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        
    }
}
