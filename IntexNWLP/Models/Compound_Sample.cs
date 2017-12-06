using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Compound_Sample")]
    public class Compound_Sample
    {
        [Key]
        public int compoundSampleId { get; set; }
        public int compoundSequenceCode { get; set; }
        public decimal quantity { get; set; }
        public DateTime? dateArrived { get; set; }
        public string receivedBy { get; set; }
        public DateTime dateDue { get; set; }
        public string appearance { get; set; }
        public decimal weightIndicatedByCustomer { get; set; }
        public decimal? weightActual { get; set; }
        public decimal? molecularMass { get; set; }
        public decimal? maxToleratedDose { get; set; }

        [ForeignKey("Compound")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}