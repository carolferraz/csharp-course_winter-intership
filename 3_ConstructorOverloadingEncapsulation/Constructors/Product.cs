using System;
using System.Globalization;

namespace Constructor
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalAmountInStock()
        {
            return Quantity * Price;
        }
        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }
        public override string ToString()
        {
            return Name
            + ", R$ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades. Valor total em estoque: R$ "
            + TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}