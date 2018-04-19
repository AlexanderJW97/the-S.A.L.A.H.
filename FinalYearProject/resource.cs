using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace theSALAH
{
    public class resource
    {
        [Key]
        public int resourceID { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string notes { get; set; }

        public resource()
        { }

        public resource(string newName, int newQuantity)
        {
            name = newName;
            quantity = newQuantity;
        }
        public resource(string newName, int newQuantity, string locationNotes)
        {
            name = newName;
            quantity = newQuantity;
            notes = locationNotes;
        }

        public static resource GetResource(int resourceID)
        {
            using (var ctx = new SALAHContext())
            {
                resource resourceQuery = ctx.Resources.FirstOrDefault(r => r.resourceID == resourceID);
                return resourceQuery;
            }
        }

        public static bool addNewResource(resource resource)
        {
            bool resourceAdded = false;
            try
            {
                using (var ctx = new SALAHContext())
                {
                    ctx.Resources.Add(resource);
                    ctx.SaveChanges();
                }
                resourceAdded = true;
                return resourceAdded;

            }
            catch
            {
                resourceAdded = false;
                return resourceAdded;
            }
        }

        public static string[] getResourceNames(string[] resourceIds)
        {
            string[] resourceNames = new string[resourceIds.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in resourceIds)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Resources //create a query to find the groupIDs of the logged in user
                                where data.resourceID == idInt
                                select new { data.name };

                    foreach (var result in query)
                    {
                        resourceNames[i] = result.name;
                        i++;
                    }

                }
            }

            return resourceNames;
        }
        public static int[] getResourceQuantities(string[] resourceIds)
        {
            int[] resourceQuantities = new int[resourceIds.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in resourceIds)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Resources //create a query to find the groupIDs of the logged in user
                                where data.resourceID == idInt
                                select new { data.quantity };

                    foreach (var result in query)
                    {
                        resourceQuantities[i] = result.quantity;
                        i++;
                    }

                }
            }

            return resourceQuantities;
        }
        public static string[] getResourceNotes(string[] resourceIds)
        {
            string[] resourceNotes = new string[resourceIds.Length];

            int i = 0;

            using (var ctx = new SALAHContext())
            {
                foreach (string s in resourceIds)
                {
                    int idInt = 0;
                    if (s != null && s != "")
                        idInt = int.Parse(s);
                    var query = from data in ctx.Resources //create a query to find the groupIDs of the logged in user
                                where data.resourceID == idInt
                                select new { data.notes };

                    foreach (var result in query)
                    {
                        resourceNotes[i] = result.notes;
                        i++;
                    }

                }
            }

            return resourceNotes;
        }

        public static bool DeleteResource(int resourceID)
        {
            bool resourceDeleted = false;
            resource resourceQuery = new resource();

            using (var ctx = new SALAHContext())
            {
                try
                {
                    resourceQuery = ctx.Resources.FirstOrDefault(r => r.resourceID == resourceID);
                    ctx.Resources.Remove(resourceQuery);
                    ctx.SaveChanges();
                    ctx.Dispose();
                    resourceDeleted = true;
                }
                catch
                {
                    resourceDeleted = false;
                }
            }
            return resourceDeleted;
        }

        public static bool ChangeLocationOfResource(int resourceId, int oldLocationId, int newLocationId, bool moveResource)
        {
            bool resourceMoved = true;
            string resourceIdString = resourceId.ToString();
            location oldLocation = new location();
            location newLocation = new location();
            resource resource = new resource();
            try
            {
                if (moveResource == true)
                {
                    using (var ctx = new SALAHContext())
                    {

                        oldLocation = ctx.Locations.FirstOrDefault(l => l.locationID == oldLocationId);
                        resource = ctx.Resources.FirstOrDefault(r => r.resourceID == resourceId);
                        location.RemoveResourceFromLocation(oldLocation, resource);
                        location.addResourceToLocation(newLocationId, resourceId);
                        resourceMoved = true;
                        ctx.SaveChanges();
                        ctx.Dispose();
                        return resourceMoved;
                    }
                }
                return resourceMoved;
            }
            catch
            {
                resourceMoved = false;
                return resourceMoved;
            }
        }
    }
}
