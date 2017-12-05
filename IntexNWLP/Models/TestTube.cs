using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("TestTube")]
    public class TestTube
    {
        [Key]
        public int testTubeId { get; set; }
        public int compoundSampleId { get; set; }
        public double concentration { get; set; }
        public double quantity { get; set; }
        
        [ForeignKey("Tests")]
        public virtual int testId { get; set; }
        public virtual Tests Test { get; set; }

    }
}