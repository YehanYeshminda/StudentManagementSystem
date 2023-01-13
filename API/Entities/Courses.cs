namespace API.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }        
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }        
    }
}