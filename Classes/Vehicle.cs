using System;
namespace CarPark
{
    public abstract class Vehicle
    { 
        int slotsFilled;
        public Vehicle()
        {

        }

        public int SlotsFilled { get => slotsFilled; set => slotsFilled = value; }
    }
}

