using System;

namespace ruj3wt
{
    class Program
    {
        static void printAmountOfCarsAndAvailableSeats(int persons){
           int amountOfCars = (persons + 4) / 5;
           int filledCars = persons / 5;
           int unfilledCar = amountOfCars - filledCars;
            int takenSeats = persons % 5;
           int AvaliableSeats = (unfilledCar * 5) - takenSeats;
           
           System.Console.WriteLine($"för {persons} personer krävs {amountOfCars} bilar. lediga platser {AvaliableSeats} "  );
        }
        static void Main(string[] args)
        {
            printAmountOfCarsAndAvailableSeats(0);
            printAmountOfCarsAndAvailableSeats(1);
            printAmountOfCarsAndAvailableSeats(14);
            printAmountOfCarsAndAvailableSeats(15);
            printAmountOfCarsAndAvailableSeats(16);
        }

        

    }
}
