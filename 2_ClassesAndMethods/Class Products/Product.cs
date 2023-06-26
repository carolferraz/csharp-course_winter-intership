using System;
using System.Globalization;

namespace ClassesAndMethods
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

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