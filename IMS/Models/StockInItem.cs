using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class StockInItem
    {
        public StockIn StockIn { get; set; }
        public Item Item { get; set; }


        [Key,Column(Order = 1)]
        public int StockInID { get; set; }

        [Key, Column(Order = 2)]
        public string ItemID { get; set; }

        public int Quntity { get; set; }
    }
}
