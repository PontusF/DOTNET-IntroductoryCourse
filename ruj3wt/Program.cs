using System;

namespace ruj3wt
{
    class Program
    {
        static int[] amountOfCarsAndAvailableSeats(int persons){
           int amountOfCars = (persons + 4) / 5;
           int filledCars = persons / 5;
           int unfilledCar = amountOfCars - filledCars;
            int takenSeats = persons % 5;
           int AvaliableSeats = (unfilledCar * 5) - takenSeats;           
           return new int[]{amountOfCars, AvaliableSeats};
        }
        
        static void Main(string[] args)
        {
            for(int i = 0; i< 7; i++){
                int[] answers = amountOfCarsAndAvailableSeats(i);
                System.Console.WriteLine($"for {i} persons {answers[0]} cars are required. {answers[1]} available seats."  );
            }            
        }
    }
}
