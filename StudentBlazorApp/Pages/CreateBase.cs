using Microsoft.AspNetCore.Components;
using StudentBlazorApp.Data;
using StudentBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Pages
{
    public class CreateBase : ComponentBase
    {
        [Inject]
        public IStudentService studentService { get; set; }
        [Inject]
        public NavigationManager nav { get; set; }
        public Student Student { get; set; }
        public string Age { get; set; }

        protected override Task OnInitializedAsync()
        {
            Student = new Student();
            return base.OnInitializedAsync();
        }

        public async Task CreateStudent()
        {
            Student.Age = int.Parse(Age);
            await studentService.CreateStudent(Student);
            nav.NavigateTo("/student");
        }
    }
}
