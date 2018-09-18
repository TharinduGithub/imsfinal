using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class StockOut
    {
        [Key]
        public int StockOutID { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public string Recever_ID { get; set; }

        [ForeignKey("Recever_ID")]
        public Recever Recever { get; set; }

        public List<StockOutItem> Items { get; set; }
    }
}
