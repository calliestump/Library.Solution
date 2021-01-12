namespace Library.Models
{
  public class CheckedOut
  {
    public int CheckedOutId { get; set; }
    public int CopyId { get; set; }
    public int PatronId { get; set; }
    public Copy Copy { get; set; }
    public Patron Patron { get; set; }
  }
}