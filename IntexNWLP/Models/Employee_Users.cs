using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Employee_Users")]
    public class Employee_Users
    {
        [Key]
        public int employeeUserId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        
        [ForeignKey("Employees")]
        public virtual int employeeId { get; set; }
        public virtual Employees Employees { get; set; }

        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }
}