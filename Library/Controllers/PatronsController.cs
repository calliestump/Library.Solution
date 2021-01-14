using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity; 
using System.Threading.Tasks;
using System.Security.Claims;

namespace Library.Controllers 
{
  public class PatronsController : Controller
  {
    private readonly LibraryContext _db;

    public PatronsController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Patron> model = _db.Patrons.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Patron patron)
    {
      _db.Patrons.Add(patron);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisPatron = _db.Patrons
          .Include(patron => patron.Copies)
          .ThenInclude(join => join.Copy)
          .FirstOrDefault(patron => patron.PatronId == id);
      return View(thisPatron);
    }

    public ActionResult CheckoutCopy(int id) 
    {
      var thisPatron = _db.Patrons.FirstOrDefault(patrons => patrons.PatronId == id);
      ViewBag.CopyId = new SelectList(_db.Copies, "CopyId", "BookId");
      // ViewBag.BookId = new SelectList(_db.Books, "BookId", "BookName");
      return View(thisPatron);
    }

    [HttpPost]
    public ActionResult CheckoutCopy(Patron patron, int CopyId)
    {
      if (CopyId != 0)
      {
        _db.Checkouts.Add(new Checkout() { CopyId = CopyId, PatronId = patron.PatronId }); // Left off with this line.
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}

// check copyid where 
// looked where checkedout = false, then select bookid => put into list.. select list on book table using boodid and pull book name.
// 