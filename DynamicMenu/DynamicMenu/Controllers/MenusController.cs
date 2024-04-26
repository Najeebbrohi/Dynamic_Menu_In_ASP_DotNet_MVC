using DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMenu.Controllers
{
    public class MenusController : Controller
    {
        MyContext db = new MyContext();
        MenuMaster menu = new MenuMaster();
        // GET: Menus
        public ActionResult MenuList()
        {
            var menuList = db.MenuMasters.ToList();
            var meneDisplay = menu.MenuTree(menuList, null);
            return PartialView(meneDisplay);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MenuMaster menu)
        {
            db.MenuMasters.Add(menu);
            db.SaveChanges();
            return View();
        }
    }
}