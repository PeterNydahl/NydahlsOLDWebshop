namespace NydahlsWebshop1000.Models;
public class Order
{
    public int Id { get; set; }
    public List<Product>? OrderedProducts { get; set; }
    public int CustomerId { get; set; }
    public long Price { get; set; }
}
