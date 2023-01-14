using API.CustomsParams;
using API.Dtos;
using API.Entities;
using API.Extensions;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StudentsRepository : IStudentRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public StudentsRepository(DataContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<FilteredStudentsDto>> GetStudentByDobAsync(StudentFilterAgeParams studentFilterAgeParams)
        {
            var startAge = studentFilterAgeParams.StartDob.CalculateAge();
            var endDob = studentFilterAgeParams.EndDob.CalculateAge();

            var query = await _context.AppUsers
                .Where(s => s.Age >= startAge && s.Age <= endDob)
                .ProjectTo<FilteredStudentsDto>(_mapper.ConfigurationProvider)
                .AsNoTracking()
                .ToListAsync();

            return query;
        }

        public async Task<FilteredStudentsDto> GetStudentByIdAsync(int Id)
        {
            return await _context.AppUsers.Where(s => s.Id == Id)
                .ProjectTo<FilteredStudentsDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<IList<FilteredStudentsDto>> GetStudentsAsync()
        {
            var students = await _userManager.GetUsersInRoleAsync("Student");
            return _mapper.Map<IList<FilteredStudentsDto>>(students);
        }
    }
}
