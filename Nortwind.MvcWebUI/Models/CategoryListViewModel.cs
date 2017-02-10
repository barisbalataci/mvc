using System.Collections.Generic;
using Project.Shared.DataTypes.Entities;

namespace Nortwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int? CurrentCategory { get; set; }
    }
}