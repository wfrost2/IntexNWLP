using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        public int salesOrderNumber { get; set; }
        public string saleDate { get; set; }
        
        [ForeignKey("Customer")]
        public virtual int customerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Employee")]
        public virtual int employeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}