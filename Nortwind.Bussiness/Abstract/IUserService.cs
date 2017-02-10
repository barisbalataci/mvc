using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ServerBase.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(User user);
    }
}
