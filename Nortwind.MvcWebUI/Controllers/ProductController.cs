using Nortwind.Bussiness.Abstract;
using Nortwind.Bussiness.Concrete.Managers;
using Nortwind.DataAcces.Concrete;
using Nortwind.DataAcces.Concrete.EntityFramework;
using Nortwind.Entities.ComplexType;
using Nortwind.Entities.Concrete;
using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Nortwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ProductController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        int pageSize = 10;
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
        public ActionResult Add(Product product)
        {
            _productService.Add(product);
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
        public ActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _productService.Delete(new Product { Id = id });
            return RedirectToAction("Index");
        }

    }
}