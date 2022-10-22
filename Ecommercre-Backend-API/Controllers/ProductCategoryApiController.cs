using Ecom_BAL.Services;
using Ecomm_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommercre_Backend_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductCategoryApiController : ControllerBase
    {
        private readonly ProductCategoryService productCategoryService;

        public ProductCategoryApiController(ProductCategoryService productCategoryService)
        {
            this.productCategoryService = productCategoryService;
        }
        [HttpPost("CreateProductCategory")]
        public async Task<Object> CreateProductCategory([FromBody] ProductCategory product)
        {
            try
            {
                await productCategoryService.AddProductCategory(product);
                return product;

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
