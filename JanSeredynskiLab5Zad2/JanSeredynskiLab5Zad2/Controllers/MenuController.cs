using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace JanSeredynskiLab5Zad2.Controllers
{
    public class MenuController : Controller
    {
        

        //
        // GET: /Menu/
       
        public ActionResult Index()
        {
            JanSeredynskiLab5Zad2.Models.DataClassesPizzaMenuDataContext dcPizzaMenu =
                new Models.DataClassesPizzaMenuDataContext();

            JanSeredynskiLab5Zad2.Models.PizzaOrderDBContext dcPizzaOrder =
                new Models.PizzaOrderDBContext();

            ViewBag.PizzaMenuList = (from pizza in dcPizzaMenu.Pizzas
                             select pizza).ToList();

            JanSeredynskiLab5Zad2.Models.PizzaOrder singlePizzaOrder= new Models.PizzaOrder();
            singlePizzaOrder.IsReceived = 0;
            singlePizzaOrder.OrderTime = DateTime.Now;
            dcPizzaOrder.PizzaOrders.Add(singlePizzaOrder);
            dcPizzaOrder.SaveChanges();
            ViewBag.PizzaOrderID = singlePizzaOrder.PizzaOrderID;
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(int pizzaOrderID, int pizzaMenuID)
        {
            JanSeredynskiLab5Zad2.Models.DataClassesPizzaMenuDataContext dcPizzaMenu =
                new Models.DataClassesPizzaMenuDataContext();

            JanSeredynskiLab5Zad2.Models.PizzaOrderListDBContext dbPizzaOrderList =
                new Models.PizzaOrderListDBContext();
            JanSeredynskiLab5Zad2.Models.PizzaOrder singlePizzaOrder = new Models.PizzaOrder();

            JanSeredynskiLab5Zad2.Models.PizzaOrderList singlePizzaOrderList = new Models.PizzaOrderList();
            singlePizzaOrderList.PizzaMenuID = pizzaMenuID;
            singlePizzaOrderList.PizzaOrderID = pizzaOrderID;
            dbPizzaOrderList.PizzaOrderLists.Add(singlePizzaOrderList);
            dbPizzaOrderList.SaveChanges();


            ViewBag.PizzaOrderID = pizzaOrderID;
            ViewBag.PizzaMenuList = (from pizza in dcPizzaMenu.Pizzas
                             select pizza).ToList();
            
            List<int> query= (from order in dbPizzaOrderList.PizzaOrderLists
                         where order.PizzaOrderID == pizzaOrderID
                         select order.PizzaMenuID).ToList();
            ViewBag.query = query;
            var query1 = (from menu in dcPizzaMenu.Pizzas
                          where query.Contains(menu.PizzaMenuID)
                          select menu).ToList();

            ViewBag.PizzaOrderList = query1;

            return View("Index");
        }

        [HttpPost]
        public ActionResult Buy(string adress, int pizzaOrderID)
        {
            JanSeredynskiLab5Zad2.Models.PizzaOrderDBContext dbPizzaOrder =
                new Models.PizzaOrderDBContext();
            var query = (from order in dbPizzaOrder.PizzaOrders
                         where order.PizzaOrderID == pizzaOrderID
                         select order).ToList().First();

            query.Adress = adress;
            dbPizzaOrder.SaveChanges();

            return View("~/Views/Home/Index.cshtml");
        }
    }
}
