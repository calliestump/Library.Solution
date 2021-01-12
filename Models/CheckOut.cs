namespace Library.Models
{
  public class Checkout
  {
    public bool CheckedOut { get; set; } = false;
    public int CopyId { get; }
  }
}