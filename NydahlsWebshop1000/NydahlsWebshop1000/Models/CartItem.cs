using NydahlsWebshop1000.Data;

namespace NydahlsWebshop1000.Models;
public class CartItem
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public int Price { get; set; }
	public ApplicationUser? User { get; set; }
}
	