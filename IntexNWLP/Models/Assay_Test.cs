using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Assay_Test")]
    public class Assay_Test
    {
        [Key]
        public int assayTestId { get; set; }
        public DateTime assayTestDate { get; set; }
        public double assayTestCost { get; set; }
        public int assayTestHours { get; set; }
        public double basePrice { get; set; }
        public string comments { get; set; }
        
        [ForeignKey("Assay")]
        public virtual int assayId { get; set; }
        public virtual Assay Assay { get; set; }

        [ForeignKey("Test")]
        public virtual int testId { get; set; }
        public virtual Test Test { get; set; }

        [ForeignKey("Compound_Sample")]
        public virtual int compoundSampleId { get; set; }
        public virtual Compound_Sample Compound_Sample { get; set; }

        [ForeignKey("Test_Result")]
        public virtual int testResultId { get; set; }
        public virtual Test_Result Test_Result { get; set; }
    }
}