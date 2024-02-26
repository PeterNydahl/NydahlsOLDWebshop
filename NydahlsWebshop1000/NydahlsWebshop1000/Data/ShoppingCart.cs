using NydahlsWebshop1000.Models;
using NydahlsWebshop1000.Repository;

namespace NydahlsWebshop1000.Data;
public class ShoppingCart
{
    //public List<Product> CartProducs { get; set; } = new List<Product>();
    public List<Product> TypesOfProducts { get; set; } = new();

    public int HippoBirdAmount { get; set; } = 0;
    public int HippoDogAmount { get; set; } = 0;
    public int HippoSnakeAmount { get; set; } = 0;
    public int HippoTigerAmount { get; set; } = 0;
    public int HippoTurtleAmount { get; set; } = 0;

    public Dictionary<int, int> ProductsAndAmounts { get; set; } = new();


    //public void AddToOrder(Product addedProduct)
    //{
    //    CartProducs.Add(addedProduct);
    //}
    public void AddToProductsAndAmounts(Product addedProduct)
    {
        if (ProductsAndAmounts.ContainsKey(addedProduct.Id))
            ProductsAndAmounts[addedProduct.Id]++;


        //if (addedProduct.Id == 1)
        //    ProductsAndAmounts[TypesOfProducts[0]] += 1;
        //else if (addedProduct.Id == 2)
        //    ProductsAndAmounts[TypesOfProducts[1]] += 1;
        //else if (addedProduct.Id == 3)
        //    ProductsAndAmounts[TypesOfProducts[2]] += 1;
        //else if (addedProduct.Id == 4)
        //    ProductsAndAmounts[TypesOfProducts[3]] += 1;
        //else if (addedProduct.Id == 5)
        //    ProductsAndAmounts[TypesOfProducts[4]] += 1;

        //if (addedProduct.Id == 1)
        //    ProductsAndAmounts[TypesOfProducts[0]]++;
        //else if (addedProduct.Id == 2)
        //    ProductsAndAmounts[TypesOfProducts[1]]++;
        //else if (addedProduct.Id == 3)
        //    ProductsAndAmounts[TypesOfProducts[2]]++;
        //else if (addedProduct.Id == 4)
        //    ProductsAndAmounts[TypesOfProducts[3]]++;
        //else if (addedProduct.Id == 5)
        //    ProductsAndAmounts[TypesOfProducts[4]]++;

        //if(addedProduct.Id == 1)
        //    ProductsAndAmounts[TypesOfProducts[0]] = HippoBirdAmount++;
        //else if(addedProduct.Id == 2)
        //    ProductsAndAmounts[TypesOfProducts[1]] = HippoDogAmount++;
        //else if (addedProduct.Id == 3)
        //    ProductsAndAmounts[TypesOfProducts[2]] = HippoSnakeAmount++;
        //else if (addedProduct.Id == 4)
        //    ProductsAndAmounts[TypesOfProducts[3]] = HippoTigerAmount++;
        //else if (addedProduct.Id == 5)
        //    ProductsAndAmounts[TypesOfProducts[4]] = HippoTurtleAmount++;
    }
}
