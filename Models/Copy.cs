using System.Collections.Generic;

namespace Library.Models
{
  public class Copy
  {
    // public Copy()
    // {
    //   this.Books = new HashSet<Copy>();
    // }
      public int CopyId { get; set; }
      public int BookId { get; set; }
      // public int CopyQuantity { get; set; }
      
      
      public Book Book { get; set; }
      // public ICollection<Copy> Books { get; set; }
  }
}