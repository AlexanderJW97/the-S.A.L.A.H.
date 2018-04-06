using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace theSALAH
{
    public class SALAHContext : DbContext
    {
        public SALAHContext() :  base()
        { }

        public DbSet<scout> Scouts { get; set; }
        public DbSet<address> Addresses { get; set; }
        public DbSet<location> Locations { get; set; }
        public DbSet<resource> Resources { get; set; }
        public DbSet<group> Groups { get; set; }
        public DbSet<user> Users { get; set; }

    }
}
