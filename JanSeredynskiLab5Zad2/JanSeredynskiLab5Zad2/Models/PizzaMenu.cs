using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JanSeredynskiLab5Zad2.Models
{
    /// <summary>
    /// Klasa przedstawiająca menu pizz
    /// </summary>
    public class PizzaMenu
    {
        /// <summary>
        /// Zwraca nazwy wszytkich pizz
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> getAllPizzaNames()
        {
            JanSeredynskiLab5Zad2.Models.DataClassesPizzaMenuDataContext dcPizzaMenu =
                new Models.DataClassesPizzaMenuDataContext();

            var query = (from item in dcPizzaMenu.Pizzas
                         select item.Name).ToList();
            return query;
        }




    }
}