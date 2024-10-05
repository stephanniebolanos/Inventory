using Inventario1._2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario1._2.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()

        {
            using (DBModel context = new DBModel())
            {
                return View(context.TIENDA.ToList());
            }
        }

        // GET: Tienda/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.TIENDA.Where(x => x.IdTienda == id).FirstOrDefault());
            }
        }

        // GET: Tienda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tienda/Create
        [HttpPost]
        public ActionResult Create(TIENDA tienda)
        {
            try
            {
                using (DBModel context = new DBModel())
                {
                    context.TIENDA.Add(tienda);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tienda/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.TIENDA.Where(x => x.IdTienda == id).FirstOrDefault());
            }
        }

        // POST: Tienda/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TIENDA tienda)
        {
            try
            {
                using (DBModel context = new DBModel())
                {
                    context.Entry(tienda).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    context.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tienda/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel context = new DBModel())
            {
                return View(context.TIENDA.Where(x => x.IdTienda == id).FirstOrDefault());
            }
        }

        // POST: Tienda/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DBModel context = new DBModel())
                {
                    TIENDA tienda = context.TIENDA.Where(x => x.IdTienda == id).FirstOrDefault();
                    context.TIENDA.Remove(tienda);
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
