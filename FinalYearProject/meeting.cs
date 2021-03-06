﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSALAH
{
    public class meeting
    {
        [Key]
        public int meetingID { get; set; }
        public string meetingTitle { get; set; }
        public string DateTime { get; set; }
        public string meetingDesc { get; set; }
        public string Location { get; set; }
        public int attendance { get; set; }
        public string scoutsThatAttended { get; set; }

        public meeting()
        { }

        public meeting(int ID)
        {
            meetingID = ID;
            attendance = 0;
            scoutsThatAttended = "";
        }

        public meeting(int ID, string DateTime)
        {
            meetingID = ID;
            this.DateTime = DateTime;
            scoutsThatAttended = "";
            attendance = 0;
        }

        public meeting(int ID, string DateTime, string location)
        {
            meetingID = ID;
            this.DateTime = DateTime;
            Location = location;
            scoutsThatAttended = "";
            attendance = 0;
        }

        public meeting(int ID, string DateTime, string location, string description)
        {
            meetingID = ID;
            this.DateTime = DateTime;
            Location = location;
            meetingDesc = description;
            scoutsThatAttended = "";
            attendance = 0;
        }

        public meeting(int ID, string DateTime, string location, string description, string title)
        {
            meetingID = ID;
            meetingTitle = title;
            this.DateTime = DateTime;
            Location = location;
            meetingDesc = description;
            scoutsThatAttended = "";
            attendance = 0;
        }

        public static bool addNewMeeting(meeting meeting, group group)
        {
            bool meetingAdded = false;
            bool meetingAddedToGroup = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Meetings.Add(meeting);
                    ctx.SaveChanges();
                }
                meetingAddedToGroup = group.addMeetingToGroup(group.groupID, meeting.meetingID);
                if (meetingAddedToGroup)
                {
                    meetingAdded = true;
                }
                return meetingAdded;
            }
            catch
            {
                meetingAdded = false;
                return meetingAdded;
            }
        }

        public static string[] getMeetingNames(string[] meetingIDs)
        {
            string[] meetingNames = new string[meetingIDs.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in meetingIDs)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Meetings //create a query to find the groupIDs of the logged in user
                                where data.meetingID == idInt
                                select new { data.meetingTitle };

                    foreach (var result in query)
                    {
                        string title = result.meetingTitle;
                        if (title != "" && title != null)
                            meetingNames[i] = result.meetingTitle;
                        else if (title == "" || title == null)
                            meetingNames[i] = "No title given";
                    }
                    i++;

                }
            }

            return meetingNames;
        }

        public static string[] getMeetingAttendanceNumbers(string[] meetingIDs)
        {
            string[] meetingAttendanceNumbers = new string[meetingIDs.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in meetingIDs)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Meetings //create a query to find the groupIDs of the logged in user
                                where data.meetingID == idInt
                                select new { data.attendance };

                    foreach (var result in query)
                    {
                        int attendanceNum = result.attendance;
                        meetingAttendanceNumbers[i] = attendanceNum.ToString();
                    }
                    i++;

                }
            }

            return meetingAttendanceNumbers;
        }

        public static int getMeetingAttendanceNumber(int meetingId)
        {
            int attendanceNum = 0;

            using (var ctx = new SALAHContext())
            {
                meeting meetingQuery = new meeting();
                meetingQuery = ctx.Meetings.FirstOrDefault(m => m.meetingID == meetingId);
                attendanceNum = meetingQuery.attendance;
            }
            return attendanceNum;
        }


        public static meeting getMeeting(int meetingID)
        {
            meeting Meeting = new meeting();


            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Meetings //create a query to find the groupIDs of the logged in user
                            where data.meetingID == meetingID
                            select new { data.meetingTitle, data.meetingDesc, data.Location, data.DateTime };

                foreach (var result in query)
                {
                    Meeting.meetingID = meetingID;
                    Meeting.meetingDesc = result.meetingDesc;
                    Meeting.meetingTitle = result.meetingTitle;
                    Meeting.Location = result.Location;
                    Meeting.DateTime = result.DateTime;
                }
            }
            return Meeting;
        }

        public static meeting getMeetingWName(string meetingName)
        {
            meeting Meeting = new meeting();


            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Meetings //create a query to find the groupIDs of the logged in user
                            where data.meetingTitle == meetingName
                            select new { data.meetingID, data.meetingTitle, data.meetingDesc, data.Location, data.DateTime };

                foreach (var result in query)
                {
                    Meeting.meetingID = result.meetingID;
                    Meeting.meetingDesc = result.meetingDesc;
                    Meeting.meetingTitle = result.meetingTitle;
                    Meeting.Location = result.Location;
                    Meeting.DateTime = result.DateTime;
                }
            }
            return Meeting;
        }

        public static bool deleteMeeting(int meetingID)
        {
            bool meetingDeleted = false;
            meeting meetingQuery = new meeting();

            using (var ctx = new SALAHContext())
            {
                try
                {
                    meetingQuery = ctx.Meetings.FirstOrDefault(m => m.meetingID == meetingID);
                    ctx.Meetings.Remove(meetingQuery);
                    ctx.SaveChanges();
                    ctx.Dispose();
                    meetingDeleted = true;
                }
                catch
                {
                    meetingDeleted = false;
                }
            }
            return meetingDeleted;
        }

        public static DateTime[] GetMeetingDateTime(string[] meetingIDs)
        {
            DateTime[] meetingDates = new DateTime[meetingIDs.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in meetingIDs)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);

                    var query = from data in ctx.Meetings //create a query to find the groupIDs of the logged in user
                                where data.meetingID == idInt
                                select new { data.DateTime };

                    foreach (var result in query)
                    {
                        string dateTimeStr = result.DateTime;
                        if (dateTimeStr != null)
                        {
                            DateTime dateTime = Convert.ToDateTime(dateTimeStr);
                            meetingDates[i] = dateTime;
                        }
                        i++;
                    }


                }
            }
            return meetingDates;
        }

        public static bool addScoutToMeeting(int meetingID, int scoutID)
        {
            bool scoutAdded = true;

            using (var ctx = new SALAHContext())
            {
                meeting meetingQuery = new meeting();
                try
                {
                    bool scoutAlreadyAdded = false;

                    meetingQuery = ctx.Meetings.FirstOrDefault(m => m.meetingID == meetingID);
                    if (meetingQuery.scoutsThatAttended != null)
                    {
                        string[] scoutsThatAttended = meetingQuery.scoutsThatAttended.Split(',');

                        foreach (string s in scoutsThatAttended)
                        {
                            if (s == scoutID.ToString())
                                scoutAlreadyAdded = true;
                        }

                        if (scoutAlreadyAdded == false)
                        {
                            meetingQuery.scoutsThatAttended += scoutID + ",";
                            meetingQuery.attendance++;
                            ctx.SaveChanges();
                            ctx.Dispose();
                            scoutAdded = true;
                        }
                        return scoutAdded;
                    }
                    else if (meetingQuery.scoutsThatAttended == null)
                    {
                        meetingQuery.scoutsThatAttended += scoutID + ",";
                        meetingQuery.attendance++;
                        ctx.SaveChanges();
                        ctx.Dispose();
                        scoutAdded = true;
                    }
                }
                catch
                {
                    scoutAdded = false;
                    return scoutAdded;
                }
            }
            return scoutAdded;
        }

        public static bool removeScoutsFromMeeting(int meetingId, int scoutId)
        {
            bool scoutRemoved = true;

            using (var ctx = new SALAHContext())
            {
                meeting meetingQuery = new meeting();

                try
                {
                    meetingQuery = ctx.Meetings.FirstOrDefault(m => m.meetingID == meetingId);

                    string[] scoutsThatAttended = meetingQuery.scoutsThatAttended.Split(',');

                    meetingQuery.scoutsThatAttended = "";

                    foreach (string s in scoutsThatAttended)
                    {
                        if (s != scoutId.ToString())
                        {
                            meetingQuery.scoutsThatAttended = s + ",";
                        }
                    }
                }
                catch
                {
                    scoutRemoved = false;
                }
            }
            return scoutRemoved;
        }


        public static bool wasScoutAtMeeting(int meetingId, int scoutId)
        {
            bool scoutMarkedPresent = false;
            using (var ctx = new SALAHContext())
            {
                meeting meetingQuery = new meeting();
                meetingQuery = ctx.Meetings.FirstOrDefault(m => m.meetingID == meetingId);
                if (meetingQuery.scoutsThatAttended != null)
                {
                    string[] scoutsThatAttended = meetingQuery.scoutsThatAttended.Split(',');
                    foreach (string s in scoutsThatAttended)
                    {
                        if (s != null && s != "")
                        {
                            int sInt = int.Parse(s);
                            if (scoutId == sInt)
                            {
                                scoutMarkedPresent = true;
                            }
                        }
                    }
                }
                return scoutMarkedPresent;
            }
        }

        public static void addMeetingsToComboBox(string[] meetingNames, ComboBox ComboBox)
        {
            int length = meetingNames.Length; //get length of the meetings array

            for (int i = 0; i < length; i++)
            {
                string meetingName = meetingNames[i];
                if (meetingName != null && meetingName != "")
                    ComboBox.Items.Add(meetingNames[i]); //add the latest array entry into the combobox
            }

        }
    }
}

