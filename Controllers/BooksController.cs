using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

using Microsoft.AspNetCore.Authorization; // allows us to authorize users
using Microsoft.AspNetCore.Identity; // allows controller to interact with users from the database
using System.Threading.Tasks; // necessary to call async methods.
using System.Security.Claims; // claim based authorization. A claim is a form of user identification; states who the user is, not what they have access to do.

namespace Library.Controllers
{
  [Authorize] // allows access to BooksController ONLY if a user is logged in.
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public BooksController(UserManager<ApplicationUser> userManager, LibraryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index(string BookSearch)
    {
      List<Book> model = _db.Books.ToList();
      if(BookSearch!=null) {
          model = _db.Books.Where(book => book.BookName.Contains(BookSearch)).ToList();
      }
      // return View(model);

      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // refers it BooksController. FindFirst() is a method that locates the first record that meets criterea. '?' existential operator; states that we should only call the method to the right of the ? if the method to the left of the ? doesn't return null.
      var currentUser = await _userManager.FindByIdAsync(userId); //calls UserManager service. FindByIdAsync() finds a user's account by their unique ID.
      // var userBooks = _db.Books.Where(entry => entry.User.Id == currentUser.Id); 
      // stores a collection containing only the Items that are associated with the currently-logged-in user's unique Id property
      return View(model);
    } 

    public ActionResult Create()
    {
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "AuthorName");
      return View();
    }

    // Employee existingEmployee = await _context.Employees.SingleOrDefaultAsync(
    // m => m.FirstName == employee.FirstName && m.LastName == employee.LastName);

    // if (existingEmployee != null)
    // {
    // // The employee already exists.
    // // Do whatever you need to do - This is just an example.
    // ModelState.AddModelError(string.Empty, "This employee already exists.");
    // employee.Departments = _context.Departments.ToList();
    // employee.Appointments = _context.Appointments.ToList();
    // return View(employee);
    // }

    // Your existing code for creating a new employee.

    [HttpPost]
    public async Task<ActionResult> Create(Book book, int AuthorId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // refers it BooksController. FindFirst() is a method that locates the first record that meets criterea. '?' existential operator; states that we should only call the method to the right of the ? if the method to the left of the ? doesn't return null.
      var currentUser = await _userManager.FindByIdAsync(userId); //calls UserManager service. FindByIdAsync() finds a user's account by their unique ID.
      book.User = currentUser;
      var existingBook = await _db.Books.SingleOrDefaultAsync( m => m.BookName == book.BookName );
      if (existingBook != null)
      {
        //Response.Redirect("Create");
        ModelState.AddModelError(string.Empty, "This book already exists"); // Not handling exception
      }
      else
      {
        _db.Books.Add(book);
      }
    
      if (AuthorId != 0)
      {
        _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = book.BookId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      
      var thisBook = _db.Books
          .Include(book => book.Authors)
          .ThenInclude(join => join.Author)
          .Include(book => book.Copies)
          .FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    public ActionResult Edit(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "AuthorName");
      return View(thisBook);
    }
    [HttpPost]
    public ActionResult Edit(Book book, int AuthorId)
    {
      if (AuthorId != 0)
      {
        _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = book.BookId });
      }
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddAuthor(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "AuthorName");
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult AddAuthor(Book book, int AuthorId)
    {
      if (AuthorId != 0)
      {
        _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = book.BookId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
      return View(thisBook);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
      _db.Books.Remove(thisBook);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteAuthor(int joinId)
    {
      var joinEntry = _db.AuthorBook.FirstOrDefault(entry => entry.AuthorBookId == joinId);
      _db.AuthorBook.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult DeleteAll()
    {
        var allBooks = _db.Books.ToList();
        return View();
    }

    [HttpPost, ActionName("DeleteAll")]
    public ActionResult DeleteAllConfirmed()
    {
        var allBooks = _db.Books.ToList();
        foreach (var book in allBooks)
        {
            _db.Books.Remove(book);
        }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }


    public ActionResult AddCopy(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult AddCopy(Copy copy)
    {
      _db.Copies.Add(copy);
      //_db.Checkouts.Add(copy);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult CheckoutCopy(int id) // Return to after adding Patron
    // {
    //   var thisCopy = _db.Copies.FirstOrDefault(copies => copies.CopyId == id); // Logic not quite correct here..
    //   return View(thisCopy);
    // }

    // [HttpPost]
    // public ActionResult CheckoutCopy(Checkout checkout, int CopyId)
    // {
    //   if (CopyId != 0)
    //   {
    //     _db.Checkouts.Add(new Checkout() { CopyId == CopyId, CheckedOut == true }); // Left off with this line.
    //     // _db.Checkouts.CheckedOut == true; // Hopefully set CheckedOut value from false to true.. fingers crossed.
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}

