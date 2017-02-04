using System.Collections.Generic;
using Nortwind.Entities.Concrete;

namespace Nortwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int? CurrentCategory { get; set; }
    }
}