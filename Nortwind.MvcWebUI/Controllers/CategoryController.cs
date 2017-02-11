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
        IProjectService _pService;

        public CategoryController(/*ICategoryService categoryServic*/)
        {
            //_cateogoryService = categoryService;
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