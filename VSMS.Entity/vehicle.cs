using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMS.Entity
{
    public class vehicle
    {   
        [Key]
        public int vehicleId { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public string chasisNo { get; set; }
        [Required]
        public string brand { get; set; }
        [Required]
        public string manufacturer { get; set; }
        [Required]
        public string mYear { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public string engineNo { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public int bprice { get; set; }
        public int sprice { get; set; }
        public byte[] image { get; set; }
    }
}
