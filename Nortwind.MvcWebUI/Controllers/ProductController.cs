using Project.Root.Abstract;
using Project.Root.Concrete.Managers;
using Project.DataLayer.Concrete;
using Project.DataLayer.Concrete.EntityFramework;
using Project.Shared.DataTypes.ComplexType;
using Project.Shared.DataTypes.Entities;
using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Nortwind.MvcWebUI.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ProductController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public int pageSize = 10;

        [AllowAnonymous]
        public ActionResult Index(int? categoryId, int page=1)
        {

            int productCount = _productService.GetProductsCountByCategory(categoryId);
            var products = _productService.GetAll(new ProductFilter
            {
                CategoryId=categoryId,
                Page=page,
                PageSize=pageSize
            });

            return View(new ProductListViewModel
            {
                Products = products,
                PageInfo = new PagingInfo
                {
                    CurrentPage = page,
                    CurrentCategory = categoryId,
                    TotalPageCount = (int)Math.Ceiling((decimal)productCount / pageSize),
                    BaseUrl = string.Format("/Product/Index/?categoryId={0}&page=", categoryId)
                }
            });
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new ProductAddViewModel
            {                
                Categories = _categoryService.GetAll().Select(item=>new SelectListItem()
                { Text=item.CategoryName,Value=item.Id.ToString()}).ToList()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product product)
        {
            _productService.Add(product);
            TempData.Add("Message", "The Product was succesfully added");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(new ProductAddViewModel
            {
                Product=_productService.GetById(id),
                Categories = _categoryService.GetAll().Select(item => new SelectListItem()
                { Text = item.CategoryName, Value = item.Id.ToString() }).ToList()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Product product)
        {
            _productService.Update(product);
            TempData.Add("Message", "The Product was succesfully apdated");
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _productService.Delete(new Product { Id = id });
            TempData.Add("Message", "The Product was succesfully deleted");
            return RedirectToAction("Index");
        }

    }
}