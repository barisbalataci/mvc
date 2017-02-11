using Project.Shared.DataTypes.Entities;
using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project.Shared;

namespace Nortwind.MvcWebUI.Controllers
{
    
    public class AccountController : Controller
    {
        private IProjectService _pService;

        public AccountController()
        {            
        }
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user, bool rememberMe=false)
        {
            User userToCheck = _pService.GetByUserNameAndPassword(user);
            if (userToCheck==null)
            {
                TempData.Add("Message","This is not an valid username and password");
                return View();
            }
            FormsAuthentication.SetAuthCookie(user.UserName, rememberMe);
            return RedirectToAction("Index", "Product");
        }

        public  ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Product");
        }
    }
}