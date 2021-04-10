using System;

namespace dotnet_mvc_web.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPages { get; set; }

        public DateTime? CreateOn { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
