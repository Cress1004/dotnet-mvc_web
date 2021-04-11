using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc_web.Models
{
    public class BookModel
    {
        [DataType(DataType.DateTime)]
        [Display(Name="Enter date & Time")]
        public string MyField { get; set; }
        public int Id { get; set; }
        [StringLength(100, MinimumLength=5)]
        [Required(ErrorMessage = "Please enter the book's title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the book's author")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength=30)]
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        [Required(ErrorMessage = "Please enter the book's total pages")]
        [Display(Name="Total Pages of Book")]
        public int? TotalPages { get; set; }
    }
}
