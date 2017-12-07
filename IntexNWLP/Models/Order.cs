using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Customer")]
        public virtual Customer Customer { get; set; }

        [DisplayName("Order Total")]
        public decimal? orderTotal { get; set; }
        [DisplayName("Order Date")]
        public DateTime? orderDate { get; set; }
        [DisplayName("Customer Comments")]
        public string customerComments { get; set; }
        [DisplayName("Run Conditional Tests")]
        public string runConditionals { get; set; }

        [ForeignKey("Order_Status")]
        public virtual int? orderStatusId { get; set; }
        [DisplayName("Order Status")]
        public virtual Order_Status Order_Status { get; set; }

        public Order()
        {
            orderTotal = 0;
        }
    }
}