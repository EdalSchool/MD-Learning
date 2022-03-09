namespace BlazorLearning.Data
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
