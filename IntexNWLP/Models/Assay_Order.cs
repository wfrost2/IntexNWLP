using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{

    [Table("Assay_Order")]
    public class Assay_Order
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Order")]
        public virtual int orderId { get; set; }
        public virtual Order Order { get; set; }
        
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Assay")]
        public virtual int assayId { get; set; }
        public virtual Assay Assay { get; set; }

    }
}