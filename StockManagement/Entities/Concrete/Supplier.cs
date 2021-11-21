using StockManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Concrete
{
    public class Supplier : IEntity
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
    }
}
