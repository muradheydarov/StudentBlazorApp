using Microsoft.AspNetCore.Components;
using StudentBlazorApp.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentBlazorApp.Data
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;
        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task CreateStudent(Student student)
        {
            await httpClient.PostJsonAsync("api/student/create", student);
        }

        public async Task EditStudent(Student student)
        {
            await httpClient.PutJsonAsync($"api/student/Edit", student);
        }

        public async Task<Student> GetStudent(int id)
        {
            return await httpClient.GetJsonAsync<Student>($"api/student/GetStudentById/{id}");

        }

        public async Task<List<Student>> GetStudents()
        {            
            return await httpClient.GetJsonAsync<List<Student>>("api/student/GetStudents");            
        }


    }
}
