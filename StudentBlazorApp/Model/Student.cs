using StudentBlazorApp.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailValidate(EmailValue = "murad@gmail.com")]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
