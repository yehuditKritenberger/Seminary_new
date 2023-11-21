using Seminary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminary.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(9)]
        public string? TZ { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [NotMapped]
        public int Age { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public ClassStudent MyClass { get; set; }
       
    }
}
