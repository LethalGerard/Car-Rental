using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<Customer> GetCustomers();
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);
    public IEnumerable<Ibooking> GetBookings();
}
