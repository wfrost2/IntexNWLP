using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Assays")]
    public class Assays
    {
        [Key]
        public int assayId { get; set; }
        public string assayName { get; set; }
        public string protocol { get; set; }
        public int estNumDaysComplete { get; set; }
        public string assayDescription { get; set; }

        [ForeignKey("Compounds")]
        public virtual int LTNumber { get; set; }
        public virtual Compounds Compounds { get; set; }
    }
}