using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace VSMS.Entity
{
    public class user
    {   
        
        [Key]
        public int userId { get; set; }
        
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
       // [Index("IX_userName", 1, IsUnique = true)]
        public string userName { get; set; }
        [Required]
        public string userPass { get; set; }
        [Required]
        public string userType { get; set; }
        [Required]
        public string sQuestion { get; set; }
        [Required]
        public string aQuestion { get; set; }
    }

}
