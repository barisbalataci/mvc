using System.Collections.Generic;
using Project.Shared.DataTypes.Entities;
using Nortwind.MvcWebUI.HtmlHelpers;

namespace Nortwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public PagingInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}