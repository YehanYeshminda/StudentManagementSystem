using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public ICollection<Enrollments> Enrollments { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}