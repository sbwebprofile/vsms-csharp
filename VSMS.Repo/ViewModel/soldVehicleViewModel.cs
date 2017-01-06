using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMS.Repo.ViewModel
{
    public class soldVehicleViewModel
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        
        public int PriceBought { get; set; }
        public int Pricesold { get; set; }
        public string Mobile { get; set; }
        public DateTime DateSold { get; set; }
        
    }
}
