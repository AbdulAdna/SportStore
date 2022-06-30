using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ItProjectController : Controller
    {
        // GET: ItProject
        public ActionResult Index()
        {
            return View();
        }

        // GET: ItProject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItProject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItProject/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItProject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItProject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItProject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItProject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
