using Crud_Dapper01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Dapper01.Controllers
{
    public class AddDataController : Controller
    {

        List<AddProf> l1 = new List<AddProf>();
        IEnumerable<AddProf> AddProf1 = new List<AddProf>();
        public AddDataController()
        {
            
        }

        // GET: AddData
        public ActionResult Index()
        {
            
            return View(l1);
        }

        public ActionResult Test1()
        {

            return View();
        }

        // GET: AddData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddData/Create
        [HttpPost]
        public ActionResult Create(AddProf AddProf)
        {
            try
            {
                // TODO: Add insert logic here
                l1.Add(AddProf);

                return RedirectToAction("Index");
               // return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AddData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddData/Edit/5
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

        // GET: AddData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddData/Delete/5
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
