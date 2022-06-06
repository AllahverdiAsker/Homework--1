using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    internal interface IStore
    {

        int _productlimit { get => _productlimit; set => _productlimit = value; }
        double _totalincome { get => _totalincome; set => _totalincome= value; }
        Product[] products { get; }

        void Addproduct(Product product);
        void Sellproduct(string no);



    }
}
