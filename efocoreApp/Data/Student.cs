namespace efocoreApp.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string FullName
        {
            get
            {
                return Name + " " + LastName;
            }
        }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        //Studen class'tan CourseRecord'a erişmek için;
        public ICollection<CourseRecord> CourseRecords { get; set; } = new List<CourseRecord>(); //null olmasına karşın

    }
}
