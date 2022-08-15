using System;
namespace CarPark
{
    
    public class Car : Vehicle
    {
        int size = (int)VehicleSize.medium;

        public Car()
        {
           
        }

        public int Size { get => size; set => size = value; }
    }
}

