using System.Collections.Generic;

namespace Library.Models
{
  public class Copy
  {
    public Copy()
    {
      this.Patrons = new HashSet<CheckedOut>();
    }
      public int CopyId { get; set; }
      public int BookId { get; set; }
      public bool CheckedOut { get; set; } = false;
      
      public Book Book { get; set; }
    public ICollection<CheckedOut> Patrons { get; set; }
  }
}