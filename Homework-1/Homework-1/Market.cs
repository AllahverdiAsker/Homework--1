using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
   internal class Market : IStore
    {

        public int ProductLimit { get; set; }
        public double TotalIncome { get; set; }
       public Product[] products { get; }

        public void Addproduct(Product product)
        {

        }
       public  void Sellproduct(string no)
        {

        }

    }
}
