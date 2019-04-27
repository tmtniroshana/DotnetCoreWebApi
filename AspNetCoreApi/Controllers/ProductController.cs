using Microsoft.AspNetCore.Mvc;
using AspNetCoreApi.Services;
using AspNetCoreApi.Models;

namespace AspNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService _productService;
        public ProductController(ProductService productServices )
        {
            this._productService = productServices;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._productService.GetProduct());
        }

        [HttpPost]
        public ActionResult Post(ProductModels product )
        {
            this._productService.Addproduct(product);
            return Ok();
        }
    }
    
}