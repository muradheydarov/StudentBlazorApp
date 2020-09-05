using Microsoft.AspNetCore.Components;
using StudentBlazorApp.Data;
using StudentBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Pages
{
    public class StudentPageBase : ComponentBase
    {        
        [Inject]
        public IStudentService StudentService { get; set; }
        public List<Student> Students { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = await StudentService.GetStudents();
        }
    }
}
