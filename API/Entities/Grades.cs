namespace API.Entities
{
    public class Grades
    {
        public int Id { get; set; }
        public string ExamName { get; set; }
        public int Grade { get; set; }
        public DateTime DateAssigned { get; set; }
        public AppUser AppUser { get; set; }
        public Classes Classes { get; set; }        
    }
}