using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc_web.Helpers
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        public string Text { get; set; }
        // public MyCustomValidationAttribute(string text) 
        // {
        //     Text = text;
        // }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) 
            {
                string bookName = value.ToString();
                if (bookName.Contains(Text)) 
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage ?? "Book's name does not containts desired value!"); 
        }
    }
}