using Microsoft.AspNetCore.Components;
using StudentBlazorApp.Data;
using StudentBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Pages
{
    public class EditBase : ComponentBase
    {
        [Inject]
        public IStudentService studentService { get; set; }
        [Inject]
        public NavigationManager nav { get; set; }
        [Parameter]
        public string Id { get; set; }
        public Student Student { get; set; }
        public string Age { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = await studentService.GetStudent(int.Parse(Id));
            Age = Student.Age.ToString();
        }

        public async Task EditStudent()
        {
            Student.Age = int.Parse(Age);
            await studentService.EditStudent(Student);

            nav.NavigateTo("/student");
        }
    }
}
