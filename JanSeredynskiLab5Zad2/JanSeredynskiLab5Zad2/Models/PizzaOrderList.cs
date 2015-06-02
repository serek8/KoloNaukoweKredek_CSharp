using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JanSeredynskiLab5Zad2.Models
{

    /// <summary>
    /// Klasa przedstawiająca podstawowe informacje o pizzach do zamówień
    /// </summary>
    public class PizzaOrderList
    {



        public int PizzaOrderListID { get; set; }

        public int PizzaOrderID { get; set; }
        public int PizzaMenuID { get; set; }

    }
    /// <summary>
    /// Klasa przedstawiająca entity do PizzaOrderList
    /// </summary>
    public class PizzaOrderListDBContext : DbContext
    {
        public DbSet<PizzaOrderList> PizzaOrderLists { get; set; }
    }




}