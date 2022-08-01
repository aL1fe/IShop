using DataAccessLayer;
using DataAccessLayer.Models;

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
}