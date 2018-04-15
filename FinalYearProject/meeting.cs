using System;
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



    }
}
