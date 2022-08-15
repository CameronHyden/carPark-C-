using System;
namespace CarPark
{
    public class Van : Vehicle
    {
        int size = (int)VehicleSize.large;
        public Van()
        {
        }

        public int Size { get => size; set => size = value; }
    }
}

