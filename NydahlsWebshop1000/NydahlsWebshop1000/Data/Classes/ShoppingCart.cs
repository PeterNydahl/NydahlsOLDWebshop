using NydahlsWebshop1000.Models;

namespace NydahlsWebshop1000.Data.Classes;
public class ShoppingCart
{
    public List<Product> TypesOfProducts { get; set; } = new();
    public Dictionary<int, int> ProductsAndAmounts { get; set; } = new();
    public void AddToProductsAndAmounts(Product addedProduct)
    {
        if (ProductsAndAmounts.ContainsKey(addedProduct.Id))
            ProductsAndAmounts[addedProduct.Id]++;
    }
}