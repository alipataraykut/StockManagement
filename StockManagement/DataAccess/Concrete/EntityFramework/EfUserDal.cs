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
    public class EfUserDal : IUserDal
    {
        public bool AuthanticationSuccess(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var _user = context.Users.Find(1);
                if (_user.Username == user.Username && _user._Password == user._Password)
                    return true;
                else
                    return false;

                //Delege kullanarak

                //if (context.Users.Where(u => u.Username == user.Username && u._Password == user._Password).Count() == 1)
                //    return true;
                //else
                //    return false;
            }
        }
    }
}
