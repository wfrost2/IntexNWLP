using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Assay_Type")]
    public class Assay_Type
    {
        [Key]
        public int assayTypeId { get; set; }
        public string assayName { get; set; }
        public string protocol { get; set; }
        public int estNumDaysComplete { get; set; }
        public string assayDescription { get; set; }

    }
}