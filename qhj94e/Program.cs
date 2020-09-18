using System;
using System.Collections.Generic;
namespace qhj94e
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skriv en klassmetod med signatur void SquigglyWrite(string text, int amplitude) 
            som skriver ut text i mönstret av en sinusvåg som spänner över 2 * amplitude + 1 rader. 
            Våglängden på sinusvågen skall vara 10 tecken.
            */

            SquigglyWrite("abcdefghijklmnopqrustuvwxyz", 1);  
        }

        static void SquigglyWrite(string text, int amplitude) {
            /*Jag valde att lagra datan för vilka kordinater (rad, teckenIndex) i den
                slutgiltiga utskriften som inte ska vara mellanslag, utan istället chars, i en
                *Dictionary*.
                Dictionaries jag definerat nedan kan ses som en charlista av obestämd storlek.
                Istället för att använda index för att nå valuet för varje char används (int,int).

            */
            var output = new Dictionary<(int,int),char>(); //(row, index)

            //lägg in alla chars i texten i dictionaryn.
           for(int i = 0; i< text.Length; i++){
               int row = deterMineRow(i,amplitude);
               (int, int) key = (row, i);
               output.Add(key,text[i]);
           }
                            //antal rows är ju amplitude uppåt och nedåt (amplitude *2), och mittenraden (+1).
           for(int row = 0; row < amplitude*2+1; row++){
               for(int i = 0; i < text.Length; i++){

                   (int, int) key = (row, i);

                   if(output.ContainsKey(key)){
                       Console.Write(output[key]);
                   }
                   else{
                       Console.Write(' ');
                   }
               }
               Console.WriteLine();
           }
        }

        static int deterMineRow(int index, int amplitude){
            int wavelength =10;
            //Hjälp från läraren:
            // Indexet r i intervallet [0, 2 * amplitude] motsvarande raden där tecknet text[i] skall skrivas ut kan beräknas:
            return amplitude + (int)Math.Round(amplitude*Math.Sin(index * ((2*Math.PI)/(double)wavelength)));
        }


    }
}
