using StockManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string _Password { get; set; }
    }
}
