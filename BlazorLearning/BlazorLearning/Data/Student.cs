namespace BlazorLearning.Data
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age => (int)(DateTime.Now.Subtract(BirthDate).TotalDays/365);
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
