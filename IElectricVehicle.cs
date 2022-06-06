using System;
namespace Garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage {get;set;}
        void ChargeBattery();
    }

    public interface IGasVehicles
    {
        int CurrentTankPercentage {get; set;}
        void RefuelTank();
    }
}