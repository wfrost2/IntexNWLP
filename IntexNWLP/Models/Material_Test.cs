using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Material_Test")]
    public class Material_Test
    {
        [Key]
        public int materialId { get; set; }

        [ForeignKey("Test")]
        public virtual int testId { get; set; }
        public virtual Test Test { get; set; }

        public double quantity { get; set; }
    }
}