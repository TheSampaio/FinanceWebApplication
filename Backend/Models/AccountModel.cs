using System.ComponentModel.DataAnnotations;
using Backend.Enums;

namespace Backend.Models
{
    public class AccountModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Number { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [Required]
        public AccountType Type { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }
    }
}