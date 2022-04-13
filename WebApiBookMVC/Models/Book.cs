using System.ComponentModel.DataAnnotations;

namespace WebApiBookMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(60,MinimumLength = 3),Required]
        public string Title { get; set; }
        [StringLength(30,MinimumLength = 3),Required]
        public string Author { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Publisher { get; set; }
        [Display(Name = "Release Date"), DataType(DataType.Date),Required]
        public DateTime? PublishDate { get; set; }
    }
}
