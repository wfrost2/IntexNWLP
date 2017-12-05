using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        public int LTNumber { get; set; }
        public string compoundName { get; set; }
        public string compoundDescription { get; set; }

    }
}