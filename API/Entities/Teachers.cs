namespace API.Entities
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Classes> Classes { get; set; }        
    }
}