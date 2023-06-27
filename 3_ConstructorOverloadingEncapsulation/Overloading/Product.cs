using System;
using System.Globalization;

namespace Overloading
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;


        public Product()
        {
        }
        
        public Product(string name, double price, int quantity) //Using this custom Constructor we may inicialize the object already with some data, ex: "Product p = new Product("TV", 900.00, 10);"; Note that we need to have de default Constructor especify, as we have above on the 13th line.
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 5; //The default constructor receive name as null, price and quantity as 0, so this line is unnecessary. But, if you want the Product start to have a different quantity, just start with: Quantity = [any number].
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