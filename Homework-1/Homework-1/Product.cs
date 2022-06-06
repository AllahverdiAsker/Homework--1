using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    internal class Product : IStore
    {

        private string _no
        {
            get => _no;
            set => _no = value;
        }

        public string Name;
        public double Price;
        public int _count
        {
            get => _count;
            set => _count = value;
        }

        private double _productlimit { 
            
            get => _productlimit; 
            set => _productlimit = value; 
        }

        private double _totalincome { 
            get => _totalincome; 
            
            set => _totalincome = value; 
        }

        private Product[] _products;
        public Product[] products { get =>  _products; }

        public void Addproduct(Product product)
        {
            if (_productlimit > _products.Length && _no != "o")
            {
                Array.Resize(ref _products, 1);
                _products[products.Length - 1] = product;
            }


        }
        public void Sellproduct(string no)
        {
            if(_count != 0 )
            {
                _totalincome++;
                _count--;
            }
        }



    }
}
