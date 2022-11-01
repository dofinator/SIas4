using schoolAPI.Contexts;
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
        private readonly DbApplicationContext _context;
        public StudentRepository(DbApplicationContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateStudent(Student student)
        {
            try
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;


            }
            
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
