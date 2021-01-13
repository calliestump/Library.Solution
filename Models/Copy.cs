using System.Collections.Generic;

namespace Library.Models
{
  public class Copy
  {
    public Copy()
    {
      this.Patrons = new HashSet<Checkout>();
    }
      public int CopyId { get; set; }
      public int BookId { get; set; }
      
      public Book Book { get; set; }
      public ICollection<Checkout> Patrons { get; set; }
  }
}