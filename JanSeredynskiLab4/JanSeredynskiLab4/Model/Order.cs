using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab4.Model
{
    partial class Order
    {

        public static List<Order> GetAll()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            List<Order> query = (from order in dataContext.Orders
                                 select order).ToList();  //querable by zwrocilo gdyby bez list
            return query;
        }

        public static List<Order> GetByName(string name)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            List<Order> query = (from order in dataContext.Orders
                                 where order.ShipName == name
                                 select order).
                                    ToList();  //querable by zwrocilo gdyby bez list
            return query;
        }

    }
}
