namespace API.Dtos
{
    public class StudentRegisterDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }    
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; } 
        public string EmergencyContactName { get; set; }
        public string Password { get; set; }
    }
}