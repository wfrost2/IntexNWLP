using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int orderId { get; set; }

        [ForeignKey("Customers")]
        public virtual int customerId { get; set; }
        public virtual Customers Customers { get; set; }
        
        public double orderTotal { get; set; }
        public string orderDate { get; set; }
        public string customerComments { get; set; }
        public string runConditionals { get; set; }

        [ForeignKey("Order_Status")]
        public virtual int orderStatusId { get; set; }
        public virtual Order_Status Order_Status { get; set; }

    }
}