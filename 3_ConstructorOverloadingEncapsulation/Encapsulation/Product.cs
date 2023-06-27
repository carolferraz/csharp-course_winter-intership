using System;
using System.Globalization;

namespace Encapsulation
{
    public class Product
    {
        private string _name; //Using the private method, we change the varialbe name syntax.
        private double _price;
        private int _quantity;

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name) //It receiva a 'void', because don't return anything, just reassings his value.
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        // See that we don't declared the Set in the _price and _quantity variables, so we will use this code are forced to use the AddProduct and RemoveProduct.
        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        public double TotalAmountInStock()
        {
            return _quantity * _price;
        }
        public void AddProduct(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            _quantity -= quantity;
        }
        public override string ToString()
        {
            return _name
            + ", R$ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantity
            + " unidades. Valor total em estoque: R$ "
            + TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}