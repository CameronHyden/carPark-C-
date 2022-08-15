using System;
namespace CarPark
{
    public class Bike : Vehicle

    {
        int size = (int)VehicleSize.large;

        public Bike()
        {
        }

        public int Size { get => size; set => size = value; }
    }
}

