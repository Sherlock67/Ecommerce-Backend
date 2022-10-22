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
    public class ProductCategoryRepository : IProductCategory
    {
        public readonly ApplicationDbContext db;
        public ProductCategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<ProductCategory> Create(ProductCategory entity)
        {
            var obj = await db.ProductCategories.AddAsync(entity);
            db.SaveChanges();
            return obj.Entity;
        }

        public void Delete(ProductCategory entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            try
            {
                return db.ProductCategories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductCategory GetById(int Id)
        {
            return db.ProductCategories.Where(x => x.ProductID == Id).SingleOrDefault();
        }

        public void Update(ProductCategory entity)
        {
            db.ProductCategories.Update(entity);
            db.SaveChanges(); ;
        }
    }
}
