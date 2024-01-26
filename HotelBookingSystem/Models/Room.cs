using HotelBookingSystem.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingSystem.Models;

public class Room
{
    [Key]
    public short Id { get; set; }

    [Required, MaxLength(25)]
    public string RoomNumber { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public short RoomTypeId { get; set; }


    [ForeignKey(nameof(RoomTypeId))]
    public RoomType RoomType { get; set; }
}
