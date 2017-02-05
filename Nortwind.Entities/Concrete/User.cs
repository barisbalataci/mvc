using Nortwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entities.Concrete
{
    public class User:IEntity
    {
        //Entity Framework PowerTools
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
