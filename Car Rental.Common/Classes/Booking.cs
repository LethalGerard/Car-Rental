﻿using Car_Rental.Common.Enums;
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


    //räkna ut cost
    public void CalcCost(DateTime returnDate, DateTime pickupDate, int kmReturned)
    {
        var rentedDays = (returnDate - pickupDate).TotalDays;
        if (rentedDays < 1) { rentedDays = 1; }

        var distance = kmReturned - Vehicle.Odometer;

        TotalCost = rentedDays * Vehicle.CostDay + distance * Vehicle.CostKm;
    }

    public Booking(IVehicle vehicle, IPerson customer, int kmRented, DateTime pickupDate)
    {
        (Vehicle, Customer, KmRented, PickupDate)=
        (vehicle, customer, kmRented, pickupDate);
        Vehicle.VehicleStatus = VehicleStatuses.Booked;
        Status = true;
    }

    public void ReturnVehicle(DateTime returnDate, int kmReturned)
    {
        Vehicle.Odometer = kmReturned;
        ReturnDate = returnDate;
        CalcCost(ReturnDate, returnDate, kmReturned);
        Vehicle.VehicleStatus = VehicleStatuses.Available;
        Status = false;
    }

}

