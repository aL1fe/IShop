using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

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
    [Route("/GetAllProducts")]
    public  ActionResult<string> GetAllProductNames()
    {
        var productNames = _productServices.GetAllProductNames();
        return Ok(productNames);
    }

    // [HttpPost]
    // [Route("/CreateProduct")]
    // public async Task<ActionResult> CreateProduct()
    // {
    //     
    // }
}