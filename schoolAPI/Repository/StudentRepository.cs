using schoolAPI.Models;

namespace schoolAPI.Repository
{
    public interface IStudentRepository
    {
        public Task<bool> CreateStudent(Student student);
        public Task<bool> UpdateStudent(Student student);
        public Task<bool> DeleteStudent(int id);
        public Task<Student> FindStudent(int id);

    }
    public class StudentRepository : IStudentRepository
    {
        public Task<bool> CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
