using System;
using System.Globalization;

namespace Properties
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

        public string Name()
        {
            get{ return _name; }
            set {
                if (value != null && value.Length > 1)
            {
                _name = value;
            }
            }
        }
        public double Price()
        {
            get { return _price; }
        }

        public int Quantity()
        {
            get { return _quantity; }
        }
        public double TotalAmountInStock() //Pay attention that when we are creating a method that uses private variables we have to put the logic inside a get to have access to its content.
        {
           get { return _quantity * _price; }
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