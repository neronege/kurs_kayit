namespace efocoreApp.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public ICollection<CourseRecord> CourseRecords { get; set; } = new List<CourseRecord>();
    }
}
