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
<<<<<<< HEAD
        public decimal quantity { get; set; }
        public DateTime? dateArrived { get; set; }
=======
        [Range(0,100)]
        public double quantity { get; set; }
        public string dateArrived { get; set; }
>>>>>>> 3848be28143a3fea00ef7fbe9345624c2077f6fa
        public string receivedBy { get; set; }
        public string dateDue { get; set; }
        public string appearance { get; set; }
<<<<<<< HEAD
        public decimal weightIndicatedByCustomer { get; set; }
        public decimal? weightActual { get; set; }
        public decimal? molecularMass { get; set; }
        public decimal? maxToleratedDose { get; set; }
=======
        [Range(0, 100)]
        public double weightIndicatedByCustomer { get; set; }
        public double weightActual { get; set; }
        public double molecularMass { get; set; }
        [Range(0, 100)]
        public double maxToleratedDose { get; set; }
>>>>>>> 3848be28143a3fea00ef7fbe9345624c2077f6fa

        [ForeignKey("Compound")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}