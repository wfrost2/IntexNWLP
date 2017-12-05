using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Test_Results")]
    public class TestResult
    {
        [Key]
        public int testResultId { get; set; }
        
        [ForeignKey("Tests")]
        public virtual int testId { get; set; }
        public virtual Tests Test { get; set; }
        
        [ForeignKey("Assay_Results")]
        public virtual int assayResultsId { get; set; }
        public virtual Assay_Results Assay_Results { get; set; }

        [ForeignKey("Tests")]
        public virtual int nextTestId { get; set; }
        public virtual Tests NextTest { get; set; }
    }
}