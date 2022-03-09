namespace BlazorLearning.Data
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ScholarYearId { get; set; }
        public ScholarYear ScholarYear { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
