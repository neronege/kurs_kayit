using System.ComponentModel.DataAnnotations;

namespace efocoreApp.Data
{
    public class CourseRecord
    {
        [Key]
        public int RecordId { get; set; }
        public Course course { get; set; } = null;
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; } = null;

    }
}
