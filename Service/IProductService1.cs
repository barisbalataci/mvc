using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project.Shared.Concrete;

namespace Project.Server
{
    [ServiceContract()]
    public interface IProductService1
    {
        [OperationContract()]
        Product GetById(int v);
    }
}
