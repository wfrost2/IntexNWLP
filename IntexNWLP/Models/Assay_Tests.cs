using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace IntexNWLP.Models
{
    [Table("Assay_Tests")]
    public class Assay_Tests
    {
        [Key]
        public int assayTestId { get; set; }
        public DateTime assayTestDate { get; set; }
        public double assayTestCost { get; set; }
        public int assayTestHours { get; set; }
        public double basePrice { get; set; }
        public string comments { get; set; }
        
        [ForeignKey("Assays")]
        public virtual int assayId { get; set; }
        public virtual Assays Assays { get; set; }

        [ForeignKey("Tests")]
        public virtual int testId { get; set; }
        public virtual Tests Tests { get; set; }

        [ForeignKey("Compound_Samples")]
        public virtual int compoundSampleId { get; set; }
        public virtual Compound_Samples Compound_Samples { get; set; }

        [ForeignKey("Test_Results")]
        public virtual int testResultId { get; set; }
        public virtual Test_Results Test_Results { get; set; }
    }
}