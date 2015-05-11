using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab1Zad2
{
    public class ProductDescription
    {
        public string name;
        public string description;
        public int price;
        public int orderQuantity;

      public ProductDescription(string nameOfMovie, string descriptionOfMovie, int priceOfMovie)
        {
            name = nameOfMovie;
            description = descriptionOfMovie;
            price = priceOfMovie;
            orderQuantity = 0;

        }
    }
}
