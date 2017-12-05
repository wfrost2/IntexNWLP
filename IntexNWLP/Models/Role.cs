using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
    }
}