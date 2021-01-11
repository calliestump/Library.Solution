using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Controllers
{
  public class AuthorsController : Controller
  {
    private readonly LibraryContext _db;

    public AuthorsController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index(string AuthorSearch)
    {
      List<Author> model = _db.Authors.ToList();
      if(AuthorSearch!=null) {
          model = _db.Authors.Where(authors => authors.AuthorName.Contains(AuthorSearch)).ToList();
      }
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Author author)
    {
      _db.Authors.Add(author);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisAuthor = _db.Authors
          .Include(author => author.Books)
          .ThenInclude(join => join.Book)
          .FirstOrDefault(author => author.AuthorId == id);
      return View(thisAuthor);
    }

    public ActionResult Edit(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
      return View(thisAuthor);
    }

    public ActionResult Edit(Author author)
    {
      _db.Entry(author).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisBook = _db.Books.FirstOrDefault(Book => Book.BookId == id);
        return View(thisBook);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
        _db.Books.Remove(thisBook);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public ActionResult DeleteAll()
    {
        var allAuthors = _db.Authors.ToList();
        return View();
    }

    [HttpPost, ActionName("DeleteAll")]
    public ActionResult DeleteAllConfirmed()
    {
        var allAuthors = _db.Authors.ToList();
        foreach (var author in allAuthors)
        {
            _db.Authors.Remove(author);
        }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }

  }
}