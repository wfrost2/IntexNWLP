using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Office")]
    public class Office
    {
        [Key]
        public int officeId { get; set; }
        public string officeName { get; set; }
        public string officeAddress1 { get; set; }
        public string officeAddress2 { get; set; }
        public string officeCity { get; set; }
        public string officeState { get; set; }
        public string officeCountry { get; set; }
        public string officeZip { get; set; }
        public string officePhone { get; set; }
    }
}