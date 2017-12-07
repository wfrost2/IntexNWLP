using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int testId { get; set; }
        [DisplayName("Test Name")]
        public string testName { get; set; }
        [DisplayName("Quoted Price")]
        public decimal quotedPrice { get; set; }
    }
}