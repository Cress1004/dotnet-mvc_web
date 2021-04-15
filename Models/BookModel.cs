using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using dotnet_mvc_web.Data;
using dotnet_mvc_web.Enums;

namespace dotnet_mvc_web.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength=5)]
        [Required(ErrorMessage = "Please enter the book's title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the book's author")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength=30)]
        public string Description { get; set; }
        public string Category { get; set; }
        //[Required(ErrorMessage = "Please select language")]
        public int LanguageId { get; set; }
        public string Language { get; set; }
    
        [Required(ErrorMessage = "Please enter the book's total pages")]
        [Display(Name="Total Pages of Book")]
        public int? TotalPages { get; set; }
    }
}
