using System.ComponentModel.DataAnnotations;

namespace schoolAPI.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        public List<StudyProgramme> AttendingProgrammes { get; set; } = new List<StudyProgramme>();
    }
}
