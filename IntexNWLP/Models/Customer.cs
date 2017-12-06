using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerAddress1 { get; set; }
        public string customerAddress2 { get; set; }
        public string customerCity { get; set; }
        public string customerState { get; set; }
        public string customerCountry { get; set; }
        public string customerZip { get; set; }
        public string phone { get; set; }
        public string customerEmail { get; set; }

        [ForeignKey("Employee")]
        public virtual int? employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}