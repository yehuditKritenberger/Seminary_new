using Seminary.Model;

namespace Seminary.DAL
{
    public class StudentRepository : IStudentRepository
    {

        readonly SeminaryContext _seminaryContext;
        public StudentRepository(SeminaryContext SeminaryContext)
        {
            _seminaryContext = SeminaryContext;
        }


        public List<Student> GetAll()
        {
            return _seminaryContext.Students.ToList();
        }

    }
}