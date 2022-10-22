using Ecom_BAL.Services;
using Ecomm_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommercre_Backend_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NavApiController : ControllerBase
    {
        private readonly NavCategoryServices navCategoryServices;

        public NavApiController(NavCategoryServices navCategoryServices)
        {
            this.navCategoryServices = navCategoryServices;
        }
        [HttpPost("CreateNavigationCategory")]
        public async Task<Object> CreateNavigationCategory([FromBody] NavCategory navCategory)
        {
            try
            {
                await navCategoryServices.AddNewCategory(navCategory);
                return navCategory;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
