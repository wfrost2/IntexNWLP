using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Order_Status")]
    public class Order_Status
    {
        [Key]
        public int orderStatusId { get; set; }
        public string status { get; set; }
        public string statusDescription { get; set; }

    }
}