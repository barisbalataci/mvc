using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Shared;

namespace Nortwind.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private IProjectService _pService;

        public CategoryController(IProjectService pService)
        {
            _pService = pService;
        }
        public PartialViewResult List(int? categoryId)
        {

            return PartialView(new CategoryListViewModel
            {
                Categories = _pService.GetAll(),
                CurrentCategory= categoryId

            });
        }
    }
}