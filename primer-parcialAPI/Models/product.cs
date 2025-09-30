using System.ComponentModel.DataAnnotations;

namespace primer_parcialAPI.Models
{
    public sealed class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = null!;

        // nullable según el enunciado
        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // nullable según el enunciado
        public DateTime? UpdatedAt { get; set; }
    }
} ///