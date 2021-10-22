using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApplication.Data.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("StudentId")]
        public int Id { get; set; }
        
        [Column("First Name")]
        [MaxLength(60, ErrorMessage = "Maximum length of First Name is 60 characters")]
        public string FirstName { get; set; }

        [Column("Last Name")]
        [MaxLength(60, ErrorMessage = "Maximum length of last Name is 60 characters")]
        public string LastName { get; set; }

        [Column("Enrollment Date", TypeName = "datetime")]
        public DateTime? EnrollmentDate { get; set; }

        [Column("Date Of Birth", TypeName = "datetime")]
        public DateTime? DOB { get; set; }

        [Column("E-Mail",TypeName = "nvarchar(50)")]
        public string Mail { get; set; }

        [Column("Student Index", TypeName = "nvarchar(4)")]
        public string StudentIndex { get; set; }

        [Column("GPA", TypeName = "decimal(3,2)")]
        public decimal? GPA { get; set; }

        [ForeignKey("AddressId")]
        public int AddressId { get; set; }

        public virtual  List<Address> Address { get; set; }

        public virtual List<Transcript> Exams { get; set; }
    }
}