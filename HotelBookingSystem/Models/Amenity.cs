using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models;
public class Amenity
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(25)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(25)]
    public string Icon { get; set; } = string.Empty;

}
