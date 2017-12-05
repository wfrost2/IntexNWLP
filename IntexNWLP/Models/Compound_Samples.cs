﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Compound_Samples")]
    public class Compound_Samples
    {
        [Key]
        public int compoundSampleId { get; set; }
        public int compoundSequenceCode { get; set; }
        public double quantity { get; set; }
        public DateTime dateArrived { get; set; }
        public string receivedBy { get; set; }
        public DateTime dateDue { get; set; }
        public string appearance { get; set; }
        public double weightIndicatedByCustomer { get; set; }
        public double weightActual { get; set; }
        public double molecularMass { get; set; }
        public double maxToleratedDose { get; set; }

        [ForeignKey("Compounds")]
        public virtual int LTNumber { get; set; }
        public virtual Compounds Compounds { get; set; }
    }
}