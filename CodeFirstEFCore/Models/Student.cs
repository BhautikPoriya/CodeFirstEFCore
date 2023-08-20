using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFCore.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(10)")]
        [Required]
        public string Gender { get; set; }

        [Column("StudentAge")]
        [Required]
        public int? Age { get; set; }
        
        [Column("StudentStandard")]
        [Required]
        public int? Standard { get; set; }

    }
}
