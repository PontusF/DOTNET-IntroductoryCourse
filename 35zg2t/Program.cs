using System;

namespace _35zg2t
{
    class Program
    {
        static DateTime CreateDateTime(String month, int day){
            DateTime date = new DateTime();

            switch(month){
                case "January":
                    date = new DateTime(01,1,day);
                    break;
                case "February":
                    date = new DateTime(01,2,day);
                    break;
                case "Mars":
                    date = new DateTime(01,3,day);
                    break;
                case "April":
                    date = new DateTime(01,4,day);
                    break;
                case "May":
                    date = new DateTime(01,5,day);
                    break;
                 case "June":
                    date = new DateTime(01,6,day);
                    break;
                 case "July":
                    date = new DateTime(01,7,day);
                    break;
                 case "August":
                    date = new DateTime(01,8,day);
                    break;
                 case "September":
                    date = new DateTime(01,9,day);
                    break;
                 case "October":
                    date = new DateTime(01,10,day);
                    break;
                 case "November":
                    date = new DateTime(01,11,day);
                    break;
                 case "December":
                    date = new DateTime(01,12,day);
                    break;
                  
                default:
                break;
            }   
            return date;
        }

        static String DetermineStarSign(DateTime date){
            
            
            System.Collections.Specialized.OrderedDictionary starSigns = new System.Collections.Specialized.OrderedDictionary();
            starSigns.Add("capricorn" , new DateTime(01, 12, 22));
            starSigns.Add("aquarius", new DateTime(01, 1, 20));
            starSigns.Add("pisces" , new DateTime(01, 2, 19));
            starSigns.Add("aries" ,new DateTime(01, 3, 21));
            starSigns.Add("taurus" , new DateTime(01, 4, 20));
            starSigns.Add("gemini" , new DateTime(01, 5, 21));
            starSigns.Add("cancer" , new DateTime(01, 6, 21));
            starSigns.Add("leo" , new DateTime(01, 7, 23));
            starSigns.Add("virgo" , new DateTime(01, 8, 23));
            starSigns.Add("libra" , new DateTime(01, 9, 23));
            starSigns.Add("scorpio" , new DateTime(01, 10, 23));
            starSigns.Add("sagittarius" , new DateTime(01, 11, 22));
             
           
           object[] keys = new object[starSigns.Keys.Count];
           for (int i = 1; i <12; i++){
               if (date< (DateTime)starSigns[i]){
                   Console.WriteLine("HEYYYO i is: " + i);
                   return (String)keys[i-1];
               }
           }
           return(String)keys[12];

        }

        static void Main(string[] args)
        {
           String month = "maj";           
           int day= 28;
            DateTime date = CreateDateTime(month, day);
            String starSign = DetermineStarSign(date);
            Console.WriteLine("starsign is: " + starSign);
        }
    }
}
