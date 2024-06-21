using System.ComponentModel.DataAnnotations;
using CLOUD.Models.DBContext.Orders;

namespace CLOUD.Models.DBContext.ShoppingCart
{
    public class CartItem
    {
        [Key]
        public int CI_Id { get; set; }  // Unique identifier for the user on their Orders

        public int ShoppingCartId { get; set; }  // FK to ShoppingCart

        public virtual Shopping_Cart ShoppingCart { get; set; }  // Navigation property

        public int ProductId { get; set; }  // FK to Product

        public virtual Product Product { get; set; }  // Navigation property

        public int Quantity { get; set; }  // Item quantity
    }
}
