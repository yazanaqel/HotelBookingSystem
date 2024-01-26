using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required, MaxLength(10), RegularExpression("@*^[a-zA-Z]+$")]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(10)]
    public string? LastName { get; set; }

    [Required, MaxLength(10)]
    public string Role { get; set; } = "User";

    [MaxLength(10), RegularExpression("^\\+963-?9\\d{8}$")]
    public string ContactNumber { get; set; } = string.Empty;

    [MaxLength(50), Unicode(false)]
    public string? Designation { get; set; }

    [MaxLength(100)]
    public string Image { get; set; } = string.Empty;
}

