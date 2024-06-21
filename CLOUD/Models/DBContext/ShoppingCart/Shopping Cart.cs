using System.ComponentModel.DataAnnotations;
using CLOUD.Models.DBContext.Orders;

namespace CLOUD.Models.DBContext.ShoppingCart
{
    public class Shopping_Cart
    {
        [Key]
        public int S_Id { get; set; }  // Unique identifier for the user on their Cart

        public List<CartItem> Items { get; set; } = new List<CartItem>();  // Initialize an empty list

        public decimal TotalPrice => Items.Sum(item => item.Quantity * item.Product.Price);  // Calculate total price

        public void AddItem(Product product, int quantity = 1)
        {
            var existingItem = Items.FirstOrDefault(item => item.Product.P_Id == product.P_Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveItem(Product product)
        {
            Items.RemoveAll(item => item.Product.P_Id == product.P_Id);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }

}

