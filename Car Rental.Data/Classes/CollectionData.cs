using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes
{
    public class CollectionData : IData
    {
        readonly List<IPerson> _persons = new List<IPerson> ();
        readonly List<IVehicle> _vehicles = new List<IVehicles> ();
        readonly List<IBooking> _bookings = new List<IBooking> ();

        public CollectionData() => SeedData();

        void SeedData();


        IEnumerable<IPerson> GetPerson() => _person;
        IEnumerable<IBooking> GetBookings() => _booking;
        IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;
    }
}
