using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IMS.Models
{
    public class StockIn
    {
        [Key]
        public int StockInID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Supplier_ID { get; set; }

        [ForeignKey("Supplier_ID")]
        public Supplier Supplier { get; set; }

        public List<StockInItem> Items { get; set; }
    }
}
