using Nortwind.Bussiness.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.ServiceClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Product  product= WcfProxy<IProductService>.CreateChannel().GetById(1);
            Console.WriteLine(product.ProductName);
            Console.ReadLine();
        }
    }
}
