using System;
namespace CarPark
{
    public class ParkingLot
    {
        int smallSpaces;
        int regularSpaces;
        int largespaces;

        public ParkingLot(int smallSpaces, int regularSpaces, int largespaces)
        {
            this.smallSpaces = smallSpaces;
            this.regularSpaces = regularSpaces;
            this.largespaces = largespaces;
        }

        public int SmallSpaces { get => smallSpaces; set => smallSpaces = value; }
        public int RegularSpaces { get => regularSpaces; set => regularSpaces = value; }
        public int Largespaces { get => largespaces; set => largespaces = value; }

        

        public int TotalSpaces()
        {
            return smallSpaces + regularSpaces + largespaces;
        }
        public void PickSpace(String vehicle)
        {
            int delay = 2000;
            if (vehicle == "bike"){
                Console.WriteLine("checking for available spaces");
                Thread.Sleep(delay);
                ParkBike();

            }else if (vehicle == "car") {
                Console.WriteLine("checking for available spaces");
                Thread.Sleep(delay);
                ParkCar();
            }
            else if (vehicle == "van") {
                Console.WriteLine("checking for available spaces");
                Thread.Sleep(delay);
                ParkVan();
            }
            else {
                Console.WriteLine("I dont know that vehicle");
            }

        }
     
        public void ParkCar() {
            if (SmallSpaces != 0)
            {
                smallSpaces --;
                Console.WriteLine("a small space is available, come on in"); 
            }else if(regularSpaces != 0)
            {
                regularSpaces --;
                Console.WriteLine("a regular space is available, come on in") ;
            }
            else
            {
                Console.WriteLine("sorry no spaces for your car");
            }
        }


        public void ParkBike()
        {
            if (SmallSpaces != 0)
            {
                smallSpaces--;
                Console.WriteLine("a small space is available, come on in");

                Console.WriteLine($"{smallSpaces} small space remaining");

            }
            else if (regularSpaces != 0)
            {
                regularSpaces--;
                Console.WriteLine("a regular space is available, come on in");
                Console.WriteLine($"{regularSpaces} regular space remaining");
            }
            else if (largespaces !=0)
            {
                largespaces--;
                Console.WriteLine("a large space is available, come on in");
                Console.WriteLine($"{largespaces} large space remaining");
            }
            else
            {
                Console.WriteLine("sorry all full!");
            }

        }
        public void ParkVan()
        {
           if (regularSpaces >= 3)
            {
                regularSpaces -= 3;
                Console.WriteLine("a regular space is available, come on in");
                Console.WriteLine($"{regularSpaces} regular space remaining");
            }
            else if(largespaces != 0)
            {
                largespaces--;
                Console.WriteLine("a large space is available, come on in");
                Console.WriteLine($"{largespaces} large space remaining");
            }
            else
            {
                Console.WriteLine("sorry no space for your vehicle");
            }
        }
     
        

    }
}

