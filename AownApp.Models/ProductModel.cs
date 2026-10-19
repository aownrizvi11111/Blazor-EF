using System.ComponentModel.DataAnnotations;

namespace AownApp.Models
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Name is required."), StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, 99999999, ErrorMessage = "Price must be 0 or greater.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative.")]
        public int StockQuantity { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}