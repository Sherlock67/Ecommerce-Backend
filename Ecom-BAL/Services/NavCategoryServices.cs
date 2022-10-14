using Ecomm_DAL.Interface;
using Ecomm_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_BAL.Services
{
    public class NavCategoryServices
    {
        private readonly INavCategory navCategory;
        public NavCategoryServices(INavCategory navCategory)
        {
            this.navCategory = navCategory;
        }
        public async Task<NavCategory> AddNewCategory(NavCategory nav)
        {
            return await navCategory.Create(nav);
        }

    }
}
