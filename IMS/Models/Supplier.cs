using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Supplier
    {
        [Key]
        public string Code { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]                                               
        public int Mobile { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }
        
        public  int Vendor_ID { get; set; }

        [ForeignKey("Vendor_ID")]
        public Vendor Vendor { get; set; }


    }
}
