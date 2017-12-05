using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int materialId { get; set; }
        public string materialName { get; set; }
        public string materialDescription { get; set; }
    }
}