using System;
namespace Garage
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Rrrrrrrooooooooom");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehicle turns right.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle comes to a stop.");
        }
    }

    public class Cessna : Vehicle, IGasVehicles
    {

        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            if (CurrentTankPercentage < 100)
            {
                CurrentTankPercentage = 100;
            }
        }
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna blasts off.");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane comes to a stop at the end of the runway before taking off.");
        }

        public override void Turn()
        {
            Console.WriteLine("The plane does a barrel roll");
        }
    }

    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            if (CurrentChargePercentage < 100)
            {
                CurrentChargePercentage = 100;
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla autopilot AI has to decide to run people over or throw you off a cliff.");
        }

        public override void Stop()
        {
            Console.WriteLine("The tesla glides to a smoooooth stop.");
        }
    }

    public class Ram : Vehicle, IGasVehicles
    {

        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            if (CurrentTankPercentage < 100)
            {
                CurrentTankPercentage = 100;
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram spits out pillars of smoke as it passes you, Trump 2022 flag waving in the wind.");
        }
    }

    public class Zero : Vehicle, IElectricVehicle
    {
        public void ChargeBattery()
        {
            if (CurrentChargePercentage < 100)
            {
                CurrentChargePercentage = 100;
            }
        }
        public int CurrentChargePercentage { get; set; }
        public double FuelCapacity { get; set; }
    }
}
