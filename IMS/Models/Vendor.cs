using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Vendor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3)]
        [Index("IX_Code", 1, IsUnique = true)]
        public string VendorCode { get; set; }

        public List<Supplier> Suppliers { get; set; }
    }
}
