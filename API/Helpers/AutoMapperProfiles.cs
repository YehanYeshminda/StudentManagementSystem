using API.Dtos;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterDto, AppUser>();
            CreateMap<StudentRegisterDto, AppUser>()
                .ForMember(dest => dest.Age, 
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<AppUser, FilteredStudentsDto>()
                .ForMember(dest => dest.AppUserRole, opt => opt.MapFrom(src => src.UserRoles.Select(s => s.Role.Name)));
        }
    }
}