using Microsoft.AspNetCore.Components;
using StudentBlazorApp.Data;
using StudentBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentBlazorApp.Pages
{
    public class StudentDetailsBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }
        [Parameter]
        public string Id { get; set; }


        public Student Student { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetStudent(int.Parse(Id));
        }        
    }
}
