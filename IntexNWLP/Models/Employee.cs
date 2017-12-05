using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNWLP.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        public string employeeFirstName { get; set; }
        public string employeeLastName { get; set; }
        public string employeeAddress1 { get; set; }
        public string employeeAddress2 { get; set; }
        public string employeeCity { get; set; }
        public string employeeState { get; set; }
        public string employeeZip { get; set; }
        public string employeePhonePersonal { get; set; }
        public string employeePhoneWork { get; set; }
        public string employeeEmail { get; set; }

        [ForeignKey("Office")]
        public virtual int officeId { get; set; }
        public virtual Office Office { get; set; }

        [ForeignKey("Role")]
        public virtual int roleId { get; set; }
        public virtual Role Role { get; set; }
    }
}