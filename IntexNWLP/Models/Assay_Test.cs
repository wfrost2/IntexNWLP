using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Assay Test Date")]
        public DateTime assayTestDate { get; set; }
        [DisplayName("Test Cost")]
        public decimal assayTestCost { get; set; }
        [DisplayName("Test Hours")]
        public int assayTestHours { get; set; }
        [DisplayName("Base Price")]
        public decimal basePrice { get; set; }
        [DisplayName("Comments")]
        public string comments { get; set; }
        
        [ForeignKey("Assay")]
        public virtual int? assayId { get; set; }
        public virtual Assay Assay { get; set; }

        [ForeignKey("Test")]
        public virtual int testId { get; set; }
        [DisplayName("Test")]
        public virtual Test Test { get; set; }

        [ForeignKey("Compound_Sample")]
        public virtual int compoundSampleId { get; set; }
        [DisplayName("Compound Sample")]
        public virtual Compound_Sample Compound_Sample { get; set; }

        [ForeignKey("Test_Result")]
        public virtual int? testResultId { get; set; }
        [DisplayName("Test Result")]
        public virtual Test_Result Test_Result { get; set; }
    }
}