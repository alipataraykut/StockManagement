using StockManagement.DataAccess.Abstract;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public List<Category> ListAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}