using Inventario1._2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario1._2.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            using (DBModel context = new DBModel()) 
            {
                return View(context.ROL.ToList());
            }
                
        }

        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.ROL.Where(x => x.IdRol == id).FirstOrDefault());
            }
        }

        // GET: Rol/Create
        public ActionResult Create()
        {
           return View();
            
        }

        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(ROL rol)
        {
            try
            {
                using(DBModel context = new DBModel()) 
                {
                    context.ROL.Add(rol);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.ROL.Where(x => x.IdRol == id).FirstOrDefault());
            }
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ROL rol)
        {
            try
            {
                using (DBModel context = new DBModel()) 
                {
                    context.Entry(rol).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    context.SaveChanges();
                
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.ROL.Where(x => x.IdRol == id).FirstOrDefault());
            }
        }

        // POST: Rol/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DBModel context = new DBModel())
                {
                    ROL rol = context.ROL.Where(x => x.IdRol == id).FirstOrDefault();
                    context.ROL.Remove(rol);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
