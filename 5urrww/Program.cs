using System;

namespace _5urrww
{
    class Program
    {

        static bool isFifteen(int[] numbers){
            return numbers[0] + numbers[1] + numbers[2] == 15;
        }

        static bool isFifteen(int numberOne, int numberTwo, int numberThree){
            return numberOne + numberTwo + numberThree == 15;
        }

        static bool isMagicSquare(int [][] arrayOfArrays){

            foreach(int[] row in arrayOfArrays){
                if(!isFifteen(row)){
                    return false;
                }
            }

            for(int i =0; i< arrayOfArrays.Length; i++){
                
                if(!isFifteen(arrayOfArrays[0][i], arrayOfArrays[1][i],arrayOfArrays[2][i])){
                    return false;
                }             
            }
            if(arrayOfArrays[0][0] + arrayOfArrays[1][1] + arrayOfArrays[2][2] != 15){
                return false;
            }
            if(arrayOfArrays[2][0] + arrayOfArrays[1][1] + arrayOfArrays[0][2] != 15){
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] arrayZero = {2, 7 ,6};
            int[] arrayOne = {9,5 ,1};
            int[] arrayTwo = {4,3 ,8};
            int [][] arrayOfArrays = {arrayZero, arrayOne,arrayTwo};

            if(isMagicSquare(arrayOfArrays)){
                 Console.WriteLine("magisk kub!");
            }else{
                Console.WriteLine("inte magisk kub!");
            }
            

        }
    }
}
