namespace Library.Models
{
  public class Checkout
  {
    public int CheckoutId { get; set; }
    public bool CheckedOut { get; set; } = false;
    public int CopyId { get; }
  }
}