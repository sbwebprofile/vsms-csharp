using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMS.Entity;
using System.Data.Entity;

namespace VSMS.data
{
    public class VSMSContext:DBContext
    {
        public VSMSContext() : base("name=VSMSConnection") 
        { 
        
        }



    }
}
