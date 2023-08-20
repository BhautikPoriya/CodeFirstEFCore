using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFCore.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [Column("StudentAge")]
        public int Age { get; set; }
        
        [Column("StudentStandard")]
        public int Standard { get; set; }

    }
}
