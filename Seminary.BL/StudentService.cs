using Seminary.DAL;
using Seminary.Model;

namespace Seminary.BL
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository _StudentRepository;
        public StudentService(IStudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }


        public List<Student> getAll()
        {
            return _StudentRepository.GetAll();
        }
    }
}