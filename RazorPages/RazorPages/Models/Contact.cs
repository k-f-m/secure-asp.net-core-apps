using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    /// <summary>
    /// Represents a contact entity.
    /// </summary>
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [Required]
        [MinLength(3)]
        public string Salutation { get; set; } = string.Empty;

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MinLength(3)]
        public string LastName { get; set; } = string.Empty;
    }
}
