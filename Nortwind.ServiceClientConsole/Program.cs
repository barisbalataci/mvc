
using Project.Shared.DataTypes.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Shared;

namespace Project.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Product>  products= WcfProxy<IProjectService>.CreateChannel().GetAll(new Shared.DataTypes.ComplexType.ProductFilter());
            products.ForEach(p =>
            {
                Console.WriteLine(string.Format("Product Name: {0} , Category : {1} ",p.ProductName,p.Category));
            });
            
            Console.ReadLine();
        }
    }
}
