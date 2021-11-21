using StockManagement.DataAccess.Abstract;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> ListAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedProduct = context.Entry(product);
                addedProduct.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedProduct = context.Entry(product);
                updatedProduct.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedProduct = context.Entry(product);
                deletedProduct.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
