using System.ComponentModel.DataAnnotations;

namespace primer_parcialAPI.Models
{
    public sealed class SupportTicket
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Subject { get; set; } = null!;

        [Required, EmailAddress, StringLength(150)]
        public string RequesterEmail { get; set; } = null!;

        // nullable según el enunciado
        [StringLength(1000)]
        public string? Description { get; set; }

        [Required, StringLength(30)]
        public string Severity { get; set; } = null!;   // p.ej.: Low/Medium/High

        [Required, StringLength(30)]
        public string Status { get; set; } = null!;     // p.ej.: Open/InProgress/Closed

        [Required]
        public DateTime OpenedAt { get; set; } = DateTime.UtcNow;

        // nullable según el enunciado
        public DateTime? ClosedAt { get; set; }

        // nullable según el enunciado
        [StringLength(120)]
        public string? AssignedTo { get; set; }
    }
}