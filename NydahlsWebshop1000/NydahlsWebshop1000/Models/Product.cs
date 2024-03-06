namespace NydahlsWebshop1000.Models;
public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImgUrl { get; set; }
    public string? ImgUrlSoldOut { get; set; }
    public long Price { get; set; }
    public int Quantity { get; set; }
}
