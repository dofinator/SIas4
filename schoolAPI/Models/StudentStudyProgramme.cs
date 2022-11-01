using System.ComponentModel.DataAnnotations.Schema;

namespace schoolAPI.Models
{
    public class StudentStudyProgramme
    {
        [ForeignKey("StudentId")]
        public long StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("StudyProgrammeId")]
        public long StudyProgrammeId { get; set; }
        public StudyProgramme StudyProgramme { get; set; }

    }
}
