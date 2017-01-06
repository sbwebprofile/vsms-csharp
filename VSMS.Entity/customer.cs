using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMS.Entity
{
   public class customer
    {
        [Key]
        public int customerId { get; set; }
       [Required]
        public string fName { get; set; }
       [Required]
        public string lName { get; set; }
       [Required]
        public string mobile { get; set; }
       [Required]
        public string email { get; set; }
       [Required]
        public string address { get; set; }
       [Required]
        public string insuranceCompany { get; set; }
       [Required]
       [StringLength(100)]
       [Index(IsUnique = true)]
        public string insuranceId { get; set; }
       [Required]
        public DateTime invoiceDate { get; set; }
        [Required]
        public DateTime warrentyS { get; set; }
        [Required]
        public DateTime warrentyE { get; set; }
        
        [Required]
        public int vehicleId { get; set; }
        [Required]
        public string paymentType { get; set; }
        [ForeignKey("vehicleId")]                       //DataAnnotation system e fk making
        public virtual vehicle vehicle { get; set; }
       
       
    }
}
