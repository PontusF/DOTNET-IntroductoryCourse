using System;
using System.Linq; // inte säker på om jag ska använda den men om i sådana fall hur ska jag göra det. 
namespace _35zg2t
{
    class Program
    {
        static void Main(string[] args)
        {
            month();
            Console.ReadKey ();
        }
        public static void month()
            {
                System.Console.WriteLine("skriv in månaden du är född i:");
                string monthdate = Console.ReadLine();
                string [] monthdayindex = {
                    "januari",
                    "februari",
                    "mars",
                    "april",
                    "maj",
                    "juni",
                    "juli",
                    "augusti",
                    "september",
                    "oktober",
                    "november",
                    "december"
                };

                int result = Array.IndexOf(monthdayindex, monthdate) +1;
                System.Console.WriteLine(result + " är månadens nummer");




                System.Console.WriteLine("skriv in vilken dag du är född i");
                    int day = int.Parse(Console.ReadLine());
                    string stringday = "" + day;
                        if(stringday.Length == 1){
                        stringday = "0" + day;     
                        }


                string completedate =  result + stringday;
                
                int resultdata = int.Parse(completedate);

                String starsign  = "";

                if(321 <= resultdata && resultdata <= 419 ) {
                    starsign = "väduren";

                }
                else if(420 <= resultdata && resultdata <= 520  ) {
                    starsign = "oxen";

                }
                else if(521 <= resultdata && resultdata <= 621 ) {
                    starsign = "tvillingen";

                }
                else if(622 <= resultdata && resultdata <= 722 ) {
                    starsign = "kräftan";

                }
                else if(723 <= resultdata && resultdata <= 822 ) {
                    starsign = "lejonet";

                }
                else if(823 <= resultdata && resultdata <= 922 ) {
                    starsign = "ljungfrun";

                }
                else if(923 <= resultdata && resultdata <= 1022 ) {
                    starsign = "vågen";

                }
                else if(1023 <= resultdata && resultdata <= 1121 ) {
                    starsign = "skorpionen";

                }
                else if(1122 <= resultdata && resultdata <= 1221 ) {
                    starsign = "skytten";

                }
                else if(1222 <= resultdata || resultdata <= 119 ) {
                    starsign = "stenbocken";

                }
                else if(120 <= resultdata && resultdata <= 218 ) {
                    starsign = "vattunmannen";

                }
                else if(219 <= resultdata && resultdata <= 320 ) {
                    starsign = "fiskar";

                }

                Console.WriteLine($"du är född i {result} och du är stjärntecknet {starsign}");
        
            

           

           
            
            
            Console.ReadLine();
             
            }
            
            

        
    }
}