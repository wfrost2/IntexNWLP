using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Catalog_Subscription")]
    public class Catalog_Subscription
    {
        [Key]
        public int catalogSubId { get; set; }
        [DisplayName("Subscription Date")]
        public DateTime subscriptionDate { get; set; }
        public DateTime renewDate { get; set; }

        [ForeignKey("Catalog_Type")]
        public virtual int catalogType { get; set; }
        public virtual Catalog_Type Catalog_Type { get; set; }

        [ForeignKey("Customer")]
        public virtual int customerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public virtual int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}