using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimkenTest.Interface;
using TimkenTest.Models;

namespace TimkenTest.Controllers
{
    public class TimkenController : Controller
    {
        private readonly ITimkenRepo _iTimkenRepo;
        public TimkenController(ITimkenRepo iTimkenRepo)
            : base()
        {
            _iTimkenRepo = iTimkenRepo;
        }
        // GET: Timken
        public ActionResult Index()
        {
            var x = _iTimkenRepo.ListData();
            return View(x);
        }

        // GET: Timken/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Timken/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Timken/Create
        [HttpPost]
        public ActionResult Create(TimkenModel collection)
        {
            try
            {
                // TODO: Add insert logic here
               var x= _iTimkenRepo.AddData(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Timken/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Timken/Edit/5
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

        // GET: Timken/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Timken/Delete/5
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
