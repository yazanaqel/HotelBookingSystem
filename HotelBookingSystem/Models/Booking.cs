using HotelBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models;
public class Booking
{
    [Key]
    public long Id { get; set; }
    public int RoomId { get; set; }

    [Required]
    public string GuestId { get; set; } = string.Empty;
    public int Adults { get; set; }
    public int Children { get; set; }

    [Range(1,double.MaxValue)]
    public int TotalAmount { get; set; }
    public string? Remarks { get; set; }
    public DateTime CheckOutDate { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime BookedOn { get; set; }

    [ForeignKey(nameof(GuestId))]
    public virtual ApplicationUser User { get; set; }
    
    [ForeignKey(nameof(RoomId))]
    public virtual Room Room { get; set; }
}
