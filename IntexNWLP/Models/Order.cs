using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int orderId { get; set; }

        [ForeignKey("Customer")]
        public virtual int customerId { get; set; }
        public virtual Customer Customer { get; set; }
        
        public decimal? orderTotal { get; set; }
        public DateTime? orderDate { get; set; }
        public string customerComments { get; set; }
        public string runConditionals { get; set; }

        [ForeignKey("Order_Status")]
        public virtual int? orderStatusId { get; set; }
        public virtual Order_Status Order_Status { get; set; }

        public Order()
        {
            orderTotal = 0;
        }
    }
}