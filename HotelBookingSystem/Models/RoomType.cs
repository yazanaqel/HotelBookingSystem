using HotelBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models;
public class RoomType
{
    [Key]
    public short Id { get; set; }

    [Required, MaxLength(25)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Image { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    public string Description { get; set; } = string.Empty;
    public string AddedBy { get; set; } = string.Empty;
    public DateTime AddedOn { get; set; }
    public string? LastUpdatedBy { get; set; }
    public DateTime? LastUpdatedOn { get; set; }

    [Required, Range(1, double.MaxValue)]
    public decimal Price { get; set; }
    public int MaxAdults { get; set; }
    public int MaxChildren { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey(nameof(AddedBy))]
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<RoomTypeAmenity> RoomTypeAmenites { get; set; }
}
