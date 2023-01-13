namespace API.Entities
{
    public class Enrollments
    {
        public int Id { get; set; }
        public Courses Courses { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
    }
}