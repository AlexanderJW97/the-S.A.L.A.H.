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
    }
}
