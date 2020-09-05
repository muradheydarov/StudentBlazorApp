using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazorApp.Validations
{
    public class EmailValidate : ValidationAttribute
    {
        public string EmailValue { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString() == EmailValue)
            {
                return null;
            }

            return new ValidationResult($"Email is not valid ({value.ToString()})", new[] { validationContext.MemberName });
        }
    }
}
