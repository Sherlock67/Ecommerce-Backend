using Ecomm_DAL.Interface;
using Ecomm_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_DAL.Repository
{
    public class NavCategoryRepository : INavCategory
    {
        public Task<NavCategory> Create(NavCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(NavCategory entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NavCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public NavCategory GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(NavCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
