using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminary.Model
{
    [Table("Class")]
    public class ClassStudent
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? NameClass { get; set; }
        public int amountStudents { get; set; }
        public int? TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher TeacherOfClass { get; set; }
        private ICollection<Student> Students { get; set; }
    }
}
