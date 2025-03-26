using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Context;
using Razor_Blog.Model.VM;

namespace Razor_Blog.Pages
{
    public class DetailModel : PageModel
    {
        public ArticleVM ArticleDetail { get; set; }

        private readonly BlogContext _context;

        public DetailModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(Guid id, string title)
        {
            ArticleDetail = _context.Articles.Select(x => new ArticleVM()
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
