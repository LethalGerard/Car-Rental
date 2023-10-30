using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle Vehicle { get; }
    public IPerson Customer { get; }
    public int KmRented { get; }
    public int? KmReturned { get; }
    public DateTime PickupDate { get; }
    public DateTime ReturnDate { get; set; }
    public double? TotalCost { get; set; }
    public bool Status { get; set; }
}