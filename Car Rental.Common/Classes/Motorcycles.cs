using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Motorcycles : IVehicle
{
    public string RegNo { get; }
    public string Make { get; }
    public int Odometer { get; }
    public double CostKm { get; }
    public string VehicleType { get; }
    public double CostDay { get; }
    public int Status { get; }

    public Motorcycles(string regNo, string make, int odometer, double costKm, string vehicleType, double costday, int status)
        => (RegNo, Make, Odometer, CostKm, VehicleType, CostDay, Status)
        = (regNo, make, odometer, costKm, vehicleType, costday, status);
}
