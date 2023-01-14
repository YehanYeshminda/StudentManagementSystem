using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public ICollection<Classes> Classes { get; set; }
        public ICollection<Grades> Grades { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Billing> Billings { get; set; }
    }
}