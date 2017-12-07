using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Compound Sequence Code")]
        public int compoundSequenceCode { get; set; }

        [DisplayName("Quantity")]
        public decimal quantity { get; set; }
        [DisplayName("Date Arrived")]
        public DateTime? dateArrived { get; set; }
        [DisplayName("Received By")]
        public string receivedBy { get; set; }
        [DisplayName("Date Due")]
        public DateTime? dateDue { get; set; }
        [DisplayName("Appearance")]
        public string appearance { get; set; }

        [Range(0, 100)]
        [DisplayName("Weight Indicated By Customer")]
        public decimal weightIndicatedByCustomer { get; set; }
        [DisplayName("Actual Weight")]
        public decimal? weightActual { get; set; }
        [DisplayName("Molecular Mass")]
        public decimal? molecularMass { get; set; }
        [DisplayName("Maximum Tolerated Dose")]
        [Range(0, 100)]
        public decimal? maxToleratedDose { get; set; }


        [ForeignKey("Compound")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}