using StudentBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Data
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudent(int id);
        Task CreateStudent(Student student);
        Task EditStudent(Student student);
    }
}
