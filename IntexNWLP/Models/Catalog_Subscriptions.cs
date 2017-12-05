using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Catalog_Subscriptions")]
    public class Catalog_Subscriptions
    {
        [Key]
        public int catalogSubId { get; set; }
        public DateTime subscriptionDate { get; set; }
        public DateTime renewDate { get; set; }

        [ForeignKey("Catalog_Type")]
        public virtual int catalogType { get; set; }
        public virtual Catalog_Type Catalog_Type { get; set; }

        [ForeignKey("Customers")]
        public virtual int customerId { get; set; }
        public virtual Customers Customers { get; set; }

        [ForeignKey("Employees")]
        public virtual int employeeId { get; set; }
        public virtual Employees Employees { get; set; }
    }
}