using System;

namespace louisatest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En magisk fyrkant av storlek 3 x 3 är ett rutnät av talen [1, 9] 
            där summan av talen i varje rad, varje column och varje diagonal är lika.
            Skriv ett program som läser in ett rutnät av tal och testar om rutnätet är en magisk fyrkant.
            */ 
            Console.WriteLine("Hello World!");

            // som läser in ett rutnät av tal

            
            Console.WriteLine("input the first 3 numbers with an enter between");

            
            int[] row1 = new int[]{
                 int.Parse(Console.ReadLine()) ,  
                int.Parse(Console.ReadLine()) ,
                int.Parse(Console.ReadLine()) 
            };
            Console.WriteLine("input the following 3 numbers with an enter between");

            int[] row2 = new int[]{
                 int.Parse(Console.ReadLine()) ,  
                int.Parse(Console.ReadLine()) ,
                int.Parse(Console.ReadLine()) 
            };
            Console.WriteLine("input the following 3 numbers with an enter between");

            int[] row3 = new int[]{
                 int.Parse(Console.ReadLine()) ,  
                int.Parse(Console.ReadLine()) ,
                int.Parse(Console.ReadLine()) 
            };
            
           String allNumbers = "";
            
            for(int i = 0; i <3; i++){
                allNumbers += row1[i] + " ";
            }
            for(int i = 0; i <3; i++){
                allNumbers += row2[i] + " ";
            }
            for(int i = 0; i <3; i++){
                allNumbers += row3[i] + " ";
            }
            Console.WriteLine("allnumbers: " + allNumbers);
            
            bool isMagic = true;
            for(int i =1; i <=9; i++){
                if(!allNumbers.Contains(""+ i + " ")){
                    Console.WriteLine("number " + i +" is missing!");
                        isMagic = false;
                        break;
                }
            }

            
            /*En magisk fyrkant av storlek 3 x 3 är ett rutnät av talen [1, 9] 
            där summan av talen i varje rad, varje column och varje diagonal är lika.
            Skriv ett program som läser in ett rutnät av tal och testar om rutnätet är en magisk fyrkant.
            */

            


            //test rows
            if(row1[0]+row1[1]+row1[2] != 15){
                isMagic = false;
            }
            else if(row2[0]+row2[1]+row2[2] != 15){
                isMagic =false;
            }
            else if(row3[0] + row3[1] + row3[2] != 15){
                isMagic = false;
            }

       



            for(int i = 0; i <= 2; i++ ){
                if(row1[i] + row2[i] + row3[i] != 15){
                    isMagic = false;
                }
            }

            //diagonal
            if(row1[0] + row2[1] + row3[2] != 15){
                isMagic = false;
            }
            else if(row1[2] +row2[1] + row3[0] != 15){
                isMagic = false;
            }

            if(isMagic){
                Console.WriteLine("Magisk fyrkant!");
            }
            else{
                Console.WriteLine("Inte en magisk fyrkant.");
            }





         }
    }   
}
