using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Assay Name")]
        public string assayName { get; set; }
        [DisplayName("Protocol")]
        public string protocol { get; set; }
        [DisplayName("Estimated Number of Days to Complete")]
        public int estNumDaysComplete { get; set; }
        [DisplayName("Description")]
        public string assayDescription { get; set; }

    }
}