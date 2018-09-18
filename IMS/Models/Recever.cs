using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Recever
    {
        [Key]
        [Required]
        public string ReceverCode { get; set; }

        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Name { get; set; }

        public int Mobile { get; set; }

        public string Designation { get; set; }
        
    }
}
