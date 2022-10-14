using Ecomm_DAL.Data;
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
        public readonly ApplicationDbContext db;
        public NavCategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<NavCategory> Create(NavCategory entity)
        {
            var obj = await db.NavCategories.AddAsync(entity);
            db.SaveChanges();
            return obj.Entity;
        }

        public void Delete(NavCategory entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<NavCategory> GetAll()
        {
            try
            {
                return db.NavCategories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public NavCategory GetById(int Id)
        {
            return db.NavCategories.Where(x => x.CategoryId == Id).SingleOrDefault();
        }

        public void Update(NavCategory entity)
        {
            db.NavCategories.Update(entity);
            db.SaveChanges(); 
        }
    }
}
