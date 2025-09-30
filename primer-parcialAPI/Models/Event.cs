using System.ComponentModel.DataAnnotations;

namespace primer_parcialAPI.Models
{
    public sealed class Event
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Title { get; set; } = null!;

        [Required, StringLength(150)]
        public string Location { get; set; } = null!;

        [Required]
        public DateTime StartAt { get; set; }

        // nullable según el enunciado
        public DateTime? EndAt { get; set; }

        [Required]
        public bool IsOnline { get; set; }

        // nullable según el enunciado
        [StringLength(500)]
        public string? Notes { get; set; }
    }
}