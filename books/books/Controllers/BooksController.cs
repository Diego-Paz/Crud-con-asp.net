using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using books.Models;

namespace books.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                bookModel.create();
                return RedirectToAction("GuardadoExitoso");
            }
            else
            {
                return View(bookModel);
            }

        }

        public ActionResult update(decimal id)
        {
            BookModel bo = new BookModel();
            bo = bo.consultbo(id);

            return View(bo);
        }

        public ActionResult save(BookModel book)
        {
            book.update();
            return RedirectToAction("Books");
        }

        public ActionResult Books()
        {
            BookModel bo = new BookModel();
            bo.lista = bo.consult();
            return View(bo);
        }

        public ActionResult GuardadoExitoso()
        {
            return View();
        }

        public ActionResult ask(decimal id)
        {
            BookModel bo = new BookModel();
            bo = bo.consultbo(id);

            return View(bo);
        }


        public ActionResult Delete(decimal id)
        {
            BookModel bo = new BookModel();
            bo.delete(id);
            return RedirectToAction("Books");
        }
    }
}