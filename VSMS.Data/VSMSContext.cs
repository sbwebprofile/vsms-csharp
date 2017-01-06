using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VSMS.Entity;

namespace VSMS.Data
{
    public class VSMSContext : DbContext
    {

        public VSMSContext() : base("VSMSConnection") 
        { 
    
        }
      
        public DbSet<user> users { get; set; }
        public DbSet<vehicle> vehicles { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<comboboxdata> comboboxdatas { get; set; }
    }
}
