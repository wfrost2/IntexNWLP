using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Sales")]
    public class Sales
    {
        [Key]
        public int salesOrderNumber { get; set; }
        public string saleDate { get; set; }
        
        [ForeignKey("Customers")]
        public virtual int customerId { get; set; }
        public virtual Customers Customers { get; set; }

        [ForeignKey("Employees")]
        public virtual int employeeId { get; set; }
        public virtual Employees Employees { get; set; }

    }
}