using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RazorPages.Areas.Identity.Data;

// Add profile data for application users by adding properties to the RazorPagesUser class
public class RazorPagesUser : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
}

