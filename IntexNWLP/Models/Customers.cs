using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Customers")]
    public class Customers
    {
        public int customerId { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerAddress1 { get; set; }
        public string customerAddress2 { get; set; }
        public string customerCity { get; set; }
        public string customerState { get; set; }
        public string customerCountry { get; set; }
        public int customerZip { get; set; }
        public int phone { get; set; }
        public string customerEmail { get; set; }

        [ForeignKey("Employees")]
        public virtual int employeeId { get; set; }
        public virtual Employees Employees { get; set; }
    }
}