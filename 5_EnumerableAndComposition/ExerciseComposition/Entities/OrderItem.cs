using System.Globalization;
using System.Text;

namespace ExerciseComposition.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Product.Name);
            stringBuilder.Append(", $");
            stringBuilder.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            stringBuilder.Append(", Quantity: ");
            stringBuilder.Append(Quantity);
            stringBuilder.Append(", Subtotal: $");
            stringBuilder.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }
    }
}