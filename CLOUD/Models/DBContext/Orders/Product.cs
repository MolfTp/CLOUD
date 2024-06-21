using System.ComponentModel.DataAnnotations;

namespace CLOUD.Models.DBContext.Orders
{
    public class Product
    {
        [Key]
        public int P_Id { get; set; }  // Use PascalCase for Product names

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  // More descriptive name for product name

        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }  // Use decimal for currency values

        [Required]
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }  // More descriptive name for quantity
    }
}

