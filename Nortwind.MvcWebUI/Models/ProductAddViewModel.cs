using System.Collections.Generic;
using System.Web.Mvc;
using Nortwind.Entities.Concrete;

namespace Nortwind.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<SelectListItem> Categories { get; set; }
        public Product Product { get; set; }
    }
}