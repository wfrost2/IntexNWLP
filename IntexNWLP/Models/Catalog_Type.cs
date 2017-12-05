using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Catalog_Type")]
    public class Catalog_Type
    {
        [Key]
        public int catalogType { get; set; }
        public string catalogName { get; set; }
        public string catalogDescription { get; set; }
    }
}