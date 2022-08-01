using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.DTO;

namespace Gateway.Controllers;

[ApiController]
public class ProductController: ControllerBase
{
    private readonly ProductServices _productServices;
    
    public ProductController(ProductServices productServices)
    {
        _productServices = productServices;
    }
    
    [HttpGet]
    [Route("/GetAllProductNames")]
    public ActionResult<string> GetAllProductNames()
    {
        var productNames = _productServices.GetAllProductNames();
        if (productNames != null)
        {
            return Ok(productNames);
        }
        return NotFound("Products not found");
    }

    [HttpGet]
    [Route("/GetAllProducts")]
    public ActionResult<DtoProductNamePrice> GetAllProducts()
    {
        var products = _productServices.GetAllProducts();
        if (products != null)
        {
            return Ok(products);
        }
        return NotFound("Products not found");
    }

    // [HttpPost]
    // [Route("/CreateProduct")]
    // public async Task<ActionResult> CreateProduct()
    // {
    //     
    // }
}