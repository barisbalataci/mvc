
using Project.Root.Abstract;
using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _cateogoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _cateogoryService = categoryService;
        }
        public PartialViewResult List(int? categoryId)
        {

            return PartialView(new CategoryListViewModel
            {
                Categories = _cateogoryService.GetAll(),
                CurrentCategory= categoryId

            });
        }
    }
}