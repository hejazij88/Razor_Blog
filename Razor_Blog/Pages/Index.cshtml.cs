using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Context;
using Razor_Blog.Model.VM;

namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BlogContext _context;
        public List<ArticleVM?> Articles { get; set; }

        public IndexModel(ILogger<IndexModel> logger, BlogContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Articles = _context.Articles
                .Where(x => x.IsDeleted == false)
                .Select(x => new ArticleVM()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    ShortDescription = x.ShortDescription,
                }).OrderByDescending(x => x.Id).ToList();
        }

        public void OnGetDelete(Guid id)
        {
            if (id != null)
            {
                var article = _context.Articles.FirstOrDefault(a => a.Id == id);
                article.IsDeleted = true;
                _context.Articles.Update(article);
                _context.SaveChanges();
                RedirectToPage("./Index");
            }
        }
    }
}
