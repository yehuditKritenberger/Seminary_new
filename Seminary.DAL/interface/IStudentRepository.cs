using Seminary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminary.DAL
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
    }
}
