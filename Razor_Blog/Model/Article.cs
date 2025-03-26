using System.ComponentModel.DataAnnotations;

namespace Razor_Blog.Model
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; }= DateTime.Now;
    }
}
