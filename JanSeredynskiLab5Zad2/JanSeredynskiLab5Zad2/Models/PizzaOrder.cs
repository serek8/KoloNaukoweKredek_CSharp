using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace JanSeredynskiLab5Zad2.Models
{
    /// <summary>
    /// Klasa przedstawiająca podstawowe informacje o zamówieniu
    /// </summary>
    public class PizzaOrder
    {
        
        public int PizzaOrderID { get; set; }
        public int PizzaOrderListID { get; set; }
        public string Adress { get; set; }
        public DateTime OrderTime { get; set; }
        public int IsReceived { get; set; }

    }
    /// <summary>
    /// Klasa przedstawiająca entity do PizzaOrder
    /// </summary>
    public class PizzaOrderDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }



}