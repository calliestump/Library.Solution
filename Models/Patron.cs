using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.Copies = new HashSet<Checkout>();
    }
    public int PatronId { get; set; }
    public string PatronName { get; set; }
    public ICollection<Checkout> Copies { get; set; }
  }
}