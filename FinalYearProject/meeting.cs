﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public meeting()
        { }

        public meeting(int ID)
        {
            meetingID = ID;
        }

        public meeting(int ID, string DateTime)
        {
            meetingID = ID;
            this.DateTime = DateTime;
        }

        public meeting(int ID, string DateTime, string location)
        {
            meetingID = ID;
            this.DateTime = DateTime;
            Location = location;
        }

        public meeting(int ID, string DateTime, string location, string description)
        {
            meetingID = ID;
            this.DateTime = DateTime;
            Location = location;
            meetingDesc = description;
        }

        public meeting(int ID, string DateTime, string location, string description, string title)
        {
            meetingID = ID;
            meetingTitle = title;
            this.DateTime = DateTime;
            Location = location;
            meetingDesc = description;
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
                                select new { data.meetingTitle};

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

        internal static meeting getMeeting(int meetingID)
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
    }
}

