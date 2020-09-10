using System;

namespace testing
{
    class Program
    {
        class MyDate{
                public int month;
                public int day;
                public MyDate(int month, int day){
                    this.month= month;
                    this.day = day;
                }
            }
            class StarSign{
                public MyDate start;
                public MyDate end;
                public String name;
                public StarSign(String name, MyDate start, MyDate end){
                    this.name = name;
                    this.start = start;
                    this.end = end;
                }
            }

            static bool isStarSign(StarSign sign, MyDate date){

                if(date.month < sign.start.month)   {   return false;   }
                if(date.month > sign.end.month)     {   return false;   }
                if(date.day < sign.start.day)       {   return false;   }
                if(date.day > sign.end.day)         {   return false;   }
                
                return true;
            }
        static void Main(string[] args){
            StarSign[] signs = new StarSign[]{
                new StarSign("kräfta", new MyDate(06, 20),new MyDate(07, 22)),
                new StarSign("Stenbock", new MyDate(12, 22),new MyDate(01, 19))
                //.. fyll i resten av stjärnteckerna här.
            };


            //Byt ut denna mot användar input. 
            String inputMånad = "Juli";
            int day = 22;
            MyDate birthDay;
            switch (inputMånad){
                case "juli":
                    new MyDate(07, 22);
                    break;

            }
            

            String correctSign = "undetermined";
           for(int i =0; i< signs.Length; i++){
               StarSign testSign = signs[i];
               if(isStarSign(testSign, birthDay)){
                   correctSign = testSign.name;
                   break;
               }
           }

            if(correctSign.Equals("undetermined")){
                correctSign = "stenbock";
            }

            Console.WriteLine( "du är en " + correctSign );

        }        
    }
}
