using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.Data.Models
{
    public class Exam
    {
        [Column("ExamId")]
        [Key]
        public int Id { get; set; }

        [MaxLength(400)]
        public string Name { get; set; }

        [MaxLength(400)]
        public string ProfessorName { get; set; }

        [Column("Credits", TypeName = "decimal(5,2)")]
        public decimal Credits { get; set; }

        public virtual List<Transcript> Students { get; set; }
    }
}
