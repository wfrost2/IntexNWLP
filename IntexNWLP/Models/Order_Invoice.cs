using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Order_Invoice")]
    public class Order_Invoice
    {
        [Key]
        public int orderInvoiceId { get; set; }

        [ForeignKey("Orders")]
        public virtual int orderId { get; set; }
        public virtual Orders Orders { get; set; }

        public string paymentDate { get; set; }
        public string earlyPaymentDate { get; set; }
        public double advancedAmount { get; set; }
        public double earlyPaymentDiscount { get; set; }
        public string invoiceSentDate { get; set; }
    }
}