using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HandleError]
        public ActionResult Index()
        {
            //throw exception for demo
            throw new Exception("This is unhandled exception");
            return View();
        }

        // GET: Test/Details/5
        [ErrAcross]
        public ActionResult Details(int id)
        {
            throw new Exception("This is unhandled exception");
            return View();
        }

        // GET: Test/Create
        public ViewResult NoPageFound()
        {
            Response.StatusCode = 404;
            return View("NoPageFound");
        }

       

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
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
