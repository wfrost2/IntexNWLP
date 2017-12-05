using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{

    [Table("Assay_Orders")]
    public class Assay_Orders
    {
        [Key]
        [ForeignKey("Orders")]
        public virtual int orderId { get; set; }
        public virtual Orders Orders { get; set; }
        
        [Key]
        [ForeignKey("Assays")]
        public virtual int assayId { get; set; }
        public virtual Assays Assays { get; set; }

    }
}