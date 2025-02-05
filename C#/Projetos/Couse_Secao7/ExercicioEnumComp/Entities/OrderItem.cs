using System.Globalization;

namespace ExercicioEnumComp.Entities
{
    class OrderItem
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        OrderItem() 
        {
            
        }

        public OrderItem(double price, int quantity, Product product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        { 
            return Price * Quantity; 
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
