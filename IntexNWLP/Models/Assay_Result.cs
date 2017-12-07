using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{

    [Table("Assay_Result")]
    public class Assay_Result
    {
        [Key]
        public int assayResultsId { get; set; }
        [DisplayName("Test File")]
        public String assayTestFile { get; set; }
        [DisplayName("Test Description")]
        public String assayTestDescriptive { get; set; }
        [DisplayName("Date Complete")]
        public DateTime completeDate { get; set; }

        [ForeignKey("Assay_Test")]
        public virtual int? assayTestId { get; set; }
        public virtual Assay_Test Assay_Test { get; set; }

    }
}