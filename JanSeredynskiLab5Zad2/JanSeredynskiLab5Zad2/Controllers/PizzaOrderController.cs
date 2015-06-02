using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JanSeredynskiLab5Zad2.Models;
using System.Web.UI.WebControls;

namespace JanSeredynskiLab5Zad2.Controllers
{
    public class PizzaOrderController : Controller
    {
        private PizzaOrderDBContext db = new PizzaOrderDBContext();

        //
        // GET: /PizzaOrder/
        /// <summary>
        /// Wyświetla złożone zamówienia - strefa pracownika
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(db.PizzaOrders.ToList());
        }


        //
        // GET: /PizzaOrder/Edit/5
        /// <summary>
        /// Ustawia dane zamówienie na zrealizowane/dostarczone
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            PizzaOrder pizzaorder = (from c in db.PizzaOrders where c.PizzaOrderID == id
                                    select c).ToList().First();
            pizzaorder.IsReceived = 1;
            db.SaveChanges();

            return View("Index", db.PizzaOrders.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}