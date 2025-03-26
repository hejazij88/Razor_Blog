using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Context;
using Razor_Blog.Model;
using Razor_Blog.Model.VM;

namespace Razor_Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;

        public CreateArticleVM Command { get; set; }

        [TempData]
        public string Message { get; set; }

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticleVM command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article() {PictureTitle = command.PictureTitle,Body = command.Body,Picture = command.Picture,PictureAlt = command.PictureAlt,ShortDescription = command.ShortDescription,Title = command.Title};

                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToPage("/Index");
            }
            else
            {
                Message = "لطفا مقادیر خواسته شده را تکمیل نمایید.";
                return Page();
            }
        }
    }
}
