using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes
{
    public class CollectionData : IData
    {
        readonly List<IPerson> _persons = new List<IPerson> ();
        readonly List<IVehicle> _vehicles = new List<IVehicle> ();
        readonly List<IBooking> _bookings = new List<IBooking> ();

        public CollectionData() => SeedData();

        private void SeedData() 
        {

        }


        IEnumerable<IPerson> GetPerson() => _person;
        IEnumerable<IBooking> GetBookings() => _booking;
        IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;

        IEnumerable<IPerson> IData.GetPerson()
        {
            throw new NotImplementedException();
        }

        IEnumerable<IVehicle> IData.GetVehicles(VehicleStatuses status)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IBooking> IData.GetBookings()
        {
            throw new NotImplementedException();
        }
    }
}
