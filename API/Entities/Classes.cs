namespace API.Entities
{
    public class Classes
    {
        public int Id { get; set; }
        public Courses Courses { get; set; }
        public Teachers Teachers { get; set; }
        public DateTime StartSchedule { get; set; }      
        public DateTime EndSchedule { get; set; }
        public ICollection<Attendance> Attendances { get; set; }      
    }
}