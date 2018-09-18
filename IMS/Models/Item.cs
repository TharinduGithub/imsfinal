using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Item
    {
        [Key]
        [Required]
        public string ItemID { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string ItemName { get; set; }

        public Category Category { get; set; }

        [Required]
        public int ReorderPoint { get; set; }

        [Required]
        public int OpenningStock { get; set; }

        public List<StockInItem> StockIns { get; set; }

        public List<StockOutItem> StockOuts { get; set; }

        public int currentQuntity { get; set; }

        [Required]
        public double costPrice { get; set; }



    }
}
