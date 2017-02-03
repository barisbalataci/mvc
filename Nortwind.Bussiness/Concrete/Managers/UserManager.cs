using Nortwind.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.Concrete;
using Nortwind.DataAcces.Abstract;

namespace Nortwind.Bussiness.Concrete.Managers
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
         public User GetByUserNameAndPassword(User user)
        {
            return _userDal.Get(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}
