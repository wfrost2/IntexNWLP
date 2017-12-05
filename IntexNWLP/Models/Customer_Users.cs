using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Customer_Users")]
    public class Customer_Users
    {
        [Key]
        public int customerUserId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        [ForeignKey("Customers")]
        public virtual int customerId { get; set; }
        public virtual Customers Customers { get; set; }
    }
}