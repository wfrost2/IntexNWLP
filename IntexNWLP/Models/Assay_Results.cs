using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{

    [Table("Assay_Results")]
    public class Assay_Results
    {
        [Key]
        public int assayResultsId { get; set; }
        public String assayTestFile { get; set; }
        public String assayTestDescriptive { get; set; }
        public DateTime completeDate { get; set; }

        [ForeignKey("Assay_Tests")]
        public virtual int assayTestId { get; set; }
        public virtual Assay_Tests Assay_Tests { get; set; }

    }
}