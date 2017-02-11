using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project.Shared.DataTypes.Entities;

namespace Project.Shared
{
    [ServiceContract()]
    public interface IProjectService
    {
        [OperationContract()]
        Product GetById(int v);
    }
}
