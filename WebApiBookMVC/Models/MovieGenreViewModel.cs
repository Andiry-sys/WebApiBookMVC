using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApiBookMVC.Models
{
    public class BookGenreViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Genres { get; set; }
        public string BookeGenre { get; set; }
        public string SearchString { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
