using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApplication.Data.Models
{
    public class Transcript
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("ExamId", TypeName = "int")]
        public int ExamId { get; set; }

        [Column("StudentId", TypeName = "int")]
        public int StudentId { get; set; }


        [Column("Points", TypeName = "decimal(4)")]
        public decimal? Points { get; set; }

        public virtual  Exam Exam { get; set; }

        public virtual Student Student { get; set; }
    }
}