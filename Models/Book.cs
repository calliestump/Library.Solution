using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Library.Models
{
  //[AllowAnonymous]
  public class Book
  {
      public Book()
      {
        this.Authors = new HashSet<AuthorBook>();
        this.Copies = new HashSet<BookCopy>();
      }

      public int BookId { get; set; }
      public string BookName { get; set; }
      public virtual ApplicationUser User { get; set; }

      public ICollection<AuthorBook> Authors { get; }
      public ICollection<BookCopy> Copies { get; }
  }
}