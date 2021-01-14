using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

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
          model = _db.Authors.Where(author => author.AuthorName.Contains(AuthorSearch)).ToList();
      }
      return View(model);
    }

    //[Authorize(Roles = "Administrator")]
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

    //[Authorize(Roles = "Administrator")]
    public ActionResult Edit(int id)
    {
      var thisAuthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
      return View(thisAuthor);
    }

    [HttpPost]
    public ActionResult Edit(Author author)
    {
      _db.Entry(author).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    //[Authorize(Roles = "Administrator")]    
    public ActionResult Delete(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(Author => Author.AuthorId == id);
        return View(thisAuthor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisAuthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
        _db.Authors.Remove(thisAuthor);
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