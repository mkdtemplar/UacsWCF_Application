using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApplication.Data.Models
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("AddressId")]
        public int Id { get; set; }

        [Column("StreetAddress", TypeName = "nvarchar(250)")]
        public string Street { get; set; }

        [Column("City", TypeName = "nvarchar(200)")]
        public string City { get; set; }

        [Column("Country", TypeName = "nvarchar(200)")]
        public string Country { get; set; }
        
        public virtual IEnumerable<Student> Students { get; set; }
    }
}