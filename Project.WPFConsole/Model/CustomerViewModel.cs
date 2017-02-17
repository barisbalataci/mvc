using Project.WPFConsole.Helper;
using Project.Shared.DataTypes.Entities;
using Project.Shared;
using System.Collections.Generic;

namespace Project.WPFConsole.Model
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            
        }
        public List<Customer> Customers { get { return WcfHelper<IProjectService>.CreateChannel().GetCustomerList(); } }
    }
}