using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolAPI.Models
{
    public class StudyProgramme
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public List<Student> AttendingStudents = new List<Student>();
    }
}
