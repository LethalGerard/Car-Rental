using System.Globalization;

namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        string RegNo { get; }
        string Make { get; }
        int Odometer { get; }
        double CostKm { get; }
        string VehicleType { get; }
        double CostDay { get; }
        int Status { get; }
    }
}