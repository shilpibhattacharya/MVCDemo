using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int departmentId { get; set; }

        [Required]
        public string departmentName { get; set; }
    }
}
