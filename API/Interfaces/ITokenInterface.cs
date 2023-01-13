using API.Entities;

namespace API.Interfaces
{
    public interface ITokenInterface
    {
        Task<string> CreateToken(AppUser user);
    }
}