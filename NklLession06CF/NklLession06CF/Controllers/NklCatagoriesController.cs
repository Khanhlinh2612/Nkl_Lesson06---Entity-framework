using System;
using System.Linq;
using System.Web.Mvc;
using NklLession06CF.Models;

namespace NklLession06CF.Controllers
{
    public class NklCategoriesController : Controller
    {
        private static NklBookStore nklDb;
        public NklCategoriesController()
        {
            nklDb = new NklBookStore();
        }
        // GET: NklCategories
        public ActionResult NklIndex()
        {
            var nklCategories = nklDb.NklCategories.ToList();
            return View(nklCategories);
        }

        // GET: NklCategories/NklCreate
        public ActionResult NklCreate()
        {
            var nklCategory = new NklCategory();
            return View(nklCategory);
        }
        [HttpPost]
        public ActionResult NklCreate(NklCategory nklCategory)
        {
            nklDb.NklCategories.Add(nklCategory);
            nklDb.SaveChanges();
            return RedirectToAction("NklIndex");
        }
    }
}
