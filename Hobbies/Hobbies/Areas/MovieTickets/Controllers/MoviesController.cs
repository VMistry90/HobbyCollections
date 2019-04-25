using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hobbies.Areas.MovieTickets.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MovieTickets/Movies
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieTickets/Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieTickets/Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieTickets/Movies/Create
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

        // GET: MovieTickets/Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieTickets/Movies/Edit/5
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

        // GET: MovieTickets/Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieTickets/Movies/Delete/5
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
