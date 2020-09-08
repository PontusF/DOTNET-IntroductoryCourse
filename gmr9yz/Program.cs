using System;

namespace gmr9yz
{
    class Program
    {
        static int[] sortIntArray(int[] intArray){
            int[] result = (int[])intArray.Clone();
            bool isSorted = false;
            
            while(!isSorted){

                isSorted = true;

                for(int i = 0; i < intArray.Length-1; i++){

                    if(result[i] > result [i+1]){

                        int newHigher = result[i];
                        result[i] = result[i+1];
                        result[i+1] = newHigher;

                        isSorted = false;
                    }
                }
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            //Skriv ett program som läser in tre heltal och skriver ut dem sorterade.
            //min lösning fungerar på N antal tal.

            int[] test1 = {10, 2, 8, 32,100 , -34,  100 , 2};
            int[] result = sortIntArray(test1);
            
            Console.WriteLine("Sorted array:");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
