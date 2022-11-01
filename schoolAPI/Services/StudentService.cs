using schoolAPI.DTO;
using schoolAPI.Models;
using schoolAPI.Repository;

namespace schoolAPI.Services
{   
    public interface IStudentService
    {
        public Task<bool> CreateStudent(StudentDTO student);
        public Task<bool> UpdateStudent(StudentDTO student);
        public Task<bool> DeleteStudent(int id);
        public Task<StudentDTO> FindStudent(int id);
    }
    public class StudentService : IStudentService
    {
        
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<bool> CreateStudent(StudentDTO student)
        {
            try
            {
                return await _studentRepository.CreateStudent(new Student
                {
                    Name = student.Name
                ,
                    Email = student.Email
                }
            );
                
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentDTO> FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStudent(StudentDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
