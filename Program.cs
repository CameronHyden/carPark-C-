using System;

namespace CarPark // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLot carPark = new(1,0,0);
            int delay = 2000;

            Boolean endApp = false;
            while (!endApp)
            {
                Console.WriteLine($"Hello we have {carPark.TotalSpaces()} spaces, what vehicle are you driving? (bike, car, van)");
                string vehicle = Console.ReadLine()!;
                Console.WriteLine("vehicle is: " + vehicle);
                carPark.PickSpace(vehicle) ;
                Thread.Sleep(delay);
                Console.WriteLine("next car please");
                Thread.Sleep(delay);
          
                if (carPark.TotalSpaces().Equals(0))
                {
                    endApp = true;
                    Console.WriteLine("Sorry we are all full!");
                };
            }
      
           
            
          
           

        }
    }
}
