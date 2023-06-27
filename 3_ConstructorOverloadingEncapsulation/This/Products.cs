using System;
using System.Globalization;

namespace This
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price)
        {
            Quantity = 0;
        }

        public Product(string name, double price) : this() //Using the 'this' word we can reuse the already declared Constructor above, so with this syntax we'll have the Quantity of 0 as default without have to redeclare.
        {
            Name = name;
            Price = price;
        }
        public Product(string name, double price, int quantity) : this(name, price) // In this case, we are reusing the Constructor declared between the 17 to 21 lines, with the sentence ": this(name, price)", as if we were saying: "this that has already been declared will be used here".
        {
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