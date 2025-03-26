namespace Razor_Blog.Model.VM
{
    public class ArticleVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public string CreationDate { get; set; }
    }
}
