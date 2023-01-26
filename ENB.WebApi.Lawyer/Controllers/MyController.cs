using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.WebApi.Lawyer.Controllers
{
    public class MyController : Controller
    {
        // GET: MyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
