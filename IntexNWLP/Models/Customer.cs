using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("First Name")]
        public string customerFirstName { get; set; }
        [DisplayName("LastName")]
        public string customerLastName { get; set; }
        [DisplayName("Address 1")]
        public string customerAddress1 { get; set; }
        [DisplayName("Address 2")]
        public string customerAddress2 { get; set; }
        [DisplayName("City")]
        public string customerCity { get; set; }
        [DisplayName("State")]
        public string customerState { get; set; }
        [DisplayName("Country")]
        public string customerCountry { get; set; }
        [DisplayName("Zip Code")]
        public string customerZip { get; set; }
        [DisplayName("Phone Number")]
        public string phone { get; set; }
        [DisplayName("Email")]
        public string customerEmail { get; set; }

        [ForeignKey("Employee")]
        public virtual int? employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}