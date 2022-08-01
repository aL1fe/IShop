using DataAccessLayer;
using DataAccessLayer.Models;
using ServiceLayer.DTO;

namespace ServiceLayer;

public class ProductServices
{
    private readonly AppDbContext _context;

    public ProductServices(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<string>? GetAllProductNames()
    {
        var productNames = _context.Products?.Select(x => x.Name);
        return productNames;
    }

    public IEnumerable<DtoProductNamePrice>? GetAllProducts()
    {
        var products = _context.Products;
        return products.Select(product => new DtoProductNamePrice() {Name = product.Name, Price = product.Price}).ToList();
        //var dtoProducts = new List<DtoProductNamePrice>();
        // foreach (var product in products)
        // {
        //     dtoProducts.Add(new DtoProductNamePrice() {Name = product.Name, Quantity = product.Quantity});
        // }
        //return dtoProducts;
    }
}