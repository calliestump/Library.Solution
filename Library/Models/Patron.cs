using System.Collections.Generic;

namespace Library.Models
{
    public class Patron
  {

    public Patron()
    {
      this.Copies = new HashSet<CheckedOut>();
    }

    // public string Id { get; set; } // From AspNetUserTable ?? 
    public int PatronId { get; set; }
    public string PatronName { get; set; }

    public virtual ApplicationUser User { get; set; }

    public PatronStatus Status { get; set; }

    public ICollection<CheckedOut> Copies { get; set; }
    
  }

  public enum PatronStatus 
  {
    Submitted,
    Approved,
    Rejected
  }
}