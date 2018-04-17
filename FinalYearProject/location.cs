using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSALAH
{
    public class location
    {
        [Key]
        public int locationID { get; set; }
        public string locationName { get; set; }
        public address Address { get; set; }
        public string resourceIDs { get; set; }
        public string venueNotes { get; set; }

        public location()
        {

        }

        public location(string name)
        {
            locationName = name;
        }

        public static bool addLocation(location location)
        {
            bool locationAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Locations.Add(location);
                    ctx.SaveChanges();
                    locationAdded = true;
                    return locationAdded;
                }

            }
            catch
            {
                locationAdded = false;
                return locationAdded;
            }
        }

        public static location getLocationWId(string locationID)
        {
            location location = new location();

            if (locationID != null && locationID != "")
            {
                int locationIDInt = int.Parse(locationID);
                using (var ctx = new SALAHContext())
                {
                    var query = from data in ctx.Locations //create a query to find the groupIDs of the logged in user
                                where data.locationID == locationIDInt
                                select new { data.locationName, data.Address, data.resourceIDs };

                    foreach (var result in query)
                    {
                        location.locationName = result.locationName;
                        location.Address = result.Address;
                        location.resourceIDs = result.resourceIDs;
                    }
                }
            }
            return location;
        }

        public static location getLocationWName(string locationName)
        {
            location location = new location();

            using (var ctx = new SALAHContext())
            {
                location = ctx.Locations.FirstOrDefault(l => l.locationName == locationName);
            }
            return location;
        }

        public static bool checkLocationExists(string locationName)
        {
            location location = new location();
            bool locationExists = false;

            using (var ctx = new SALAHContext())
            {
                location = ctx.Locations.FirstOrDefault(l => l.locationName == locationName);

                if (location != null)
                {
                    locationExists = true;
                }
            }
            return locationExists;
        }

        public static bool checkResources(location location)
        {
            bool hasResources = false;

            if (location.resourceIDs != "" && location.resourceIDs != null)
                hasResources = true;

            return hasResources;
        }

        public static bool addResourceToLocation(location location, int resourceId)
        {
            bool resourceAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    if (location.resourceIDs != null)
                    {
                        string[] locationsResources = location.resourceIDs.Split(',');

                        location.resourceIDs = "";

                        foreach (string s in locationsResources)
                        {
                            if (s != "" && s != null)
                            {
                                location.resourceIDs = location.resourceIDs + s + ",";
                            }
                        }
                        location.resourceIDs += resourceId + ",";
                    }
                    if (location.resourceIDs == null)
                    {
                        location.resourceIDs = resourceId + ",";
                    }

                    ctx.SaveChanges();
                    resourceAdded = true;
                    return resourceAdded;
                }
            }
            catch
            {
                resourceAdded = false;
                return resourceAdded;
            }
        }

        public static string[] getLocationResources(location location)
        {
            string[] resourceIDsArray = location.resourceIDs.Split(',');

            int count = 0;
            foreach (string s in resourceIDsArray)
            {
                if (s != null && s != "")
                {
                    count++;
                }
            }
            string[] resourceIDs = new string[count];
            int i = 0;
            foreach (string s in resourceIDsArray)
            {
                if (s != null && s != "")
                {
                    resourceIDs[i] = s;
                    i++;
                }
            }

            return resourceIDs;
        }

        public static void addLocationsToComboBox(string[] locationNames, ComboBox locationComboBox)
        {
            int length = locationNames.Length; //get length of the groupID array

            for (int i = 0; i < length; i++)
            {
                string locationName = locationNames[i];
                if (locationName != null && locationName != "")
                    locationComboBox.Items.Add(locationNames[i]); //add the latest array entry into the combobox
            }

        }

        public static bool DeleteLocation(location location, group group)
        {
            bool locationDeleted = false;
            location locationQuery = new location();
            int locationIDint = location.locationID;

            using (var ctx = new SALAHContext())
            {
                try
                {
                    locationQuery = ctx.Locations.FirstOrDefault(l => l.locationID == locationIDint);
                    ctx.Locations.Remove(locationQuery);
                    ctx.SaveChanges();
                    ctx.Dispose();
                    if (group.RemoveLocationFromGroup(location))
                    {
                        locationDeleted = true;
                    }
                }
                catch
                {
                    locationDeleted = false;
                }
            }
            return locationDeleted;
        }

        public static bool changeLocationsGroup(location location, group oldGroup, group newGroup, bool moveGroup)
        {
            bool locationMoved = true;
            string locationIDString = location.locationID.ToString();
            try
            {
                if (moveGroup == true)
                {
                    using (var ctx = new SALAHContext())
                    {
                        oldGroup = ctx.Groups.FirstOrDefault(g => g.location_ID == locationIDString);
                        oldGroup.location_ID = null;
                        newGroup = ctx.Groups.FirstOrDefault(g => g.groupID == newGroup.groupID);
                        newGroup.location_ID = location.locationID.ToString();
                        locationMoved = true;
                        ctx.SaveChanges();
                        ctx.Dispose();
                        return locationMoved;
                    }
                }
                return locationMoved;
            }
            catch
            {
                locationMoved = false;
                return locationMoved;
            }
        }
    }
}
