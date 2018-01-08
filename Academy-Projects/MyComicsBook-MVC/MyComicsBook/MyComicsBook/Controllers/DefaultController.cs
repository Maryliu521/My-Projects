using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyComicsBook.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
       {
            var comicBook = Models.ComicBookManager.GetComicBooks();
            return View(comicBook);
        }
        public ActionResult Detail(int id)
        {
            var comicBooks = Models.ComicBookManager.GetComicBooks();
            var comicBook = comicBooks.FirstOrDefault(p => p.ComicBookId == id);
            return View(comicBook);
        }
    }
}