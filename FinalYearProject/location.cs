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

        public static location getLocationWId(int locationID)
        {
            location location = new location();

            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Locations //create a query to find the groupIDs of the logged in user
                            where data.locationID == locationID
                            select new { data.locationName, data.Address, data.resourceIDs };

                foreach (var result in query)
                {
                    location.locationName = result.locationName;
                    location.Address = result.Address;
                    location.resourceIDs = result.resourceIDs;
                }
            }
            return location;
        }

        public static location getLocationWName(string locationName)
        {
            location location = new location();

            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Locations //create a query to find the groupIDs of the logged in user
                            where data.locationName == locationName
                            select new { data.locationName, data.Address, data.resourceIDs };

                foreach (var result in query)
                {
                    location.locationName = result.locationName;
                    location.Address = result.Address;
                    location.resourceIDs = result.resourceIDs;
                }
            }
            return location;
        }

        public static bool checkLocationExists(string locationName)
        {
            location location = new location();
            bool locationExists = false;

            using (var ctx = new SALAHContext())
            {
                var query = from data in ctx.Locations //create a query to find the groupIDs of the logged in user
                            where data.locationName == locationName
                            select new { data.locationName, data.Address, data.resourceIDs };

                if (query != null)
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
    }
}
