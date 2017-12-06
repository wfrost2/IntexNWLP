using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        public int assayId { get; set; }

        [ForeignKey("Assay_Type")]
        public virtual int assayTypeId { get; set; }
        public virtual Assay_Type Assay_Type { get; set; }

        [ForeignKey("Compound")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}