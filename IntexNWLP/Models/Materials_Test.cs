using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Materials_Tests")]
    public class Materials_Test
    {
        [Key]
        public int materialId { get; set; }
        public ICollection<Materials_Test> Material_Tests { get; set; }


        [ForeignKey("Tests")]
        public virtual int testId { get; set; }
        public virtual Test Test { get; set; }

        public double quantity { get; set; }
    }
}