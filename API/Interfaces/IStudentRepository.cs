using API.CustomsParams;
using API.Dtos;
using API.Entities;

namespace API.Interfaces
{
    public interface IStudentRepository
    {
        Task<IList<FilteredStudentsDto>> GetStudentsAsync();
        Task<FilteredStudentsDto> GetStudentByIdAsync(int Id);
        Task<IEnumerable<FilteredStudentsDto>> GetStudentByDobAsync(StudentFilterAgeParams studentFilterAgeParams);
        Task<bool> Complete();
    }
}