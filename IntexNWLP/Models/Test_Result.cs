using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Test_Result")]
    public class Test_Result
    {
        [Key]
        public int testResultId { get; set; }
        
        [ForeignKey("Test")]
        [Column(Order = 0)]
        public virtual int testId { get; set; }
        public virtual Test Test { get; set; }
        
        [ForeignKey("Assay_Result")]
        public virtual int assayResultsId { get; set; }
        public virtual Assay_Result Assay_Result { get; set; }

        [ForeignKey("NextTest")]
        public virtual int? nextTestId { get; set; }
        public virtual Test NextTest { get; set; }
    }
}