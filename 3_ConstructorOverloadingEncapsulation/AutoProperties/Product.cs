using System;
using System.Globalization;

namespace AutoProperties
{
    public class Product
    {
        /*Auto Properties is a simple way to implement properties that don't need specific logic to use Get and Set. In this case, we can see that _name needs a specific logic on its Set, so it will remain private in its declaration and have a space to declare its logic between the 17th to 26th lines. On the other hand, we have the Price and Quantity that have their Get and Set declared already as a properties when they are declared. Note that the Set method is private, so we can't change it without using the specific methods for that. */


        private string _name; //Using the private method, we change the varialbe name syntax.
        public double Price { get; private set; }
        public int Quantity { get; private set; }

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
            return _name
            + ", R$ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades. Valor total em estoque: R$ "
            + TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}