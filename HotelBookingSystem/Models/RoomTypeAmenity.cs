using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models;
public class RoomTypeAmenity
{
    public short RoomTypeId { get; set; }
    public int AmenityId { get; set; }
    public int? Unit { get; set; }

    public virtual Amenity Amenity { get; set; }
    public virtual RoomType RoomType { get; set; }
}
