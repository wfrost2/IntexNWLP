using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int LTNumber { get; set; }
        [DisplayName("Compound Name")]
        public string compoundName { get; set; }
        [DisplayName("Compound Description")]
        public string compoundDescription { get; set; }

    }
}