using System.ComponentModel.DataAnnotations;

namespace CLOUD.Models.DBContext.Orders
{
    public class Orders
    {
        [Key]
        public int O_Id { get; set; }  // Use PascalCase for property names

        [Required]
        public int ProductId { get; set; }  // Foreign key referencing Product

        public virtual Product product { get; set; }  // Navigation property for Product

        [Required]
        [Range(1, int.MaxValue)]  // Enforce a minimum order quantity of 1
        public int Quantity { get; set; }  // Use singular form for quantity 

        [Required]
        public decimal Price { get; set; }  // Use decimal for currency values

    }
}
