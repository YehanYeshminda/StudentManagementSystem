namespace API.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string AttendanceStatus { get; set; } = "Absent";
        public AppUser AppUser { get; set; }        
        public Classes Classes { get; set; }        
    }
}