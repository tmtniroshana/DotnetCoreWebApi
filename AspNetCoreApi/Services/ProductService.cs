using System.Collections.Generic;
using AspNetCoreApi.Models;

namespace AspNetCoreApi.Services
{
    public class ProductService
    {
        List<ProductModels> _productlist = null;
        public ProductService()
        {
            _productlist = new List<ProductModels>();
        }
        public List<ProductModels> GetProduct()
        {
            return _productlist;
        }
        public void Addproduct(ProductModels product)
        {
            _productlist.Add(product);
        }

    }
    
}