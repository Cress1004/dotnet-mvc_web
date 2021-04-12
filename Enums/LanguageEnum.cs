using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc_web.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "English")]
        English = 1,
        Vienamese = 2,
        French = 3,
        Korean = 4,
        Chinese = 5,
        Japanese = 6,
    }
}