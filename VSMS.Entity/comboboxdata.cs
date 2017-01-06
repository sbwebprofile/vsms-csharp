using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VSMS.Entity
{
    public class comboboxdata
    {
        [Key]
        public int vvvid { get; set; }
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string vehiclebrand { get; set; }
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string vehiclemanufacturar { get; set; }
  
    }
}
