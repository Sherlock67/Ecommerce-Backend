using Ecomm_DAL.Interface;
using Ecomm_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_BAL.Services
{
    
    public class ProductCategoryService
    {
        private readonly IProductCategory productCategory;
        public ProductCategoryService(IProductCategory productCategory)
        {
            this.productCategory = productCategory;
        }
        public async Task<ProductCategory> AddProductCategory(ProductCategory p)
        {
            return await productCategory.Create(p);
        }
    }
}
