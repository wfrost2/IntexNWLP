using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Tests")]
    public class Tests
    {
        [Key]
        public int testId { get; set; }
        public string testName { get; set; }
        public double quotedPrice { get; set; }
    }
}