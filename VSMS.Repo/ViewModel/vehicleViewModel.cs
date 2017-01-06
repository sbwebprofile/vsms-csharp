using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMS.Repo.ViewModel
{
   public class vehicleViewModel
    {
        
        public int vehicleId { get; set; }
      
        public string model { get; set; }
       
        public string chasisNo { get; set; }
      
        public string brand { get; set; }
      
        public string manufacturer { get; set; }
      
        public string Made_Year { get; set; }
       
        public string color { get; set; }
      
        public string engineNo { get; set; }
      
        public string status { get; set; }

        public byte[] image { get; set; }

    }
}
