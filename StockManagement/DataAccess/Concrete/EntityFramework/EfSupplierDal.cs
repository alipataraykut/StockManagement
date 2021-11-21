using StockManagement.DataAccess.Abstract;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.DataAccess.Concrete.EntityFramework
{
    public class EfSupplierDal : ISupplierDal
    {
        public List<Supplier> ListAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }
        }
    }
}
