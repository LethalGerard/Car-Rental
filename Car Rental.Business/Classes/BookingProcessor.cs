using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomer() { return _db.GetCustomer(); } 
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) { return _db.GetVehicles(status); }
    public IEnumerable<IBooking> GetBookings() {  return _db.GetBookings(); }
}
//Unable to resolve service for type 'Car_Rental.Data.Interfaces.IData' while attempting to activate 'Car_Rental.Business.Classes.BookingProcessor'.