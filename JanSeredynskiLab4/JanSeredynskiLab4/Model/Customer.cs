using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab4.Model
{
    public partial class Customer
    {
        public static List<Customer> GetAll()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            List<Customer> query = (from customer in dataContext.Customers
                                   select customer).ToList();  //querable by zwrocilo gdyby bez list
            return query;
        }

        public static List<Customer> GetByName(string name)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            List<Customer> query = (from customer in dataContext.Customers
                                    where customer.CompanyName == name
                                    select customer).
                                    ToList();  //querable by zwrocilo gdyby bez list
            return query;
        }



    }
}
