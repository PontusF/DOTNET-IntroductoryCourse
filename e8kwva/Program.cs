using System;

namespace testing
{
    class Program
    {
        public enum Player{

            //värdena 1 och 4 kommer sättas in i brädets kordinatsystem när spelarna gör drag.
            Kryss = 1,
            Ring = 4
            
        }
        
       
        
        public static void Main(string[] args){
           Player activePlayer = Player.Ring;
           bool gameActive = true;
           int[,] board = new int[3,3]{
               {0,0,0},
               {0,0,0},
               {0,0,0},
           };
            //sålänge matchen är igång
           while(gameActive){

                WriteBoard(board);                
                playerMove(board, activePlayer);

                if(playerWon(board, activePlayer)){
                    gameActive=false;
                }
                if(gameActive){
                    activePlayer = ChangePlayer(activePlayer);                    
                }                
           }

           WriteBoard(board);
           Console.WriteLine(activePlayer + " vann!");

        }    

        public static void playerMove(int[,] board, Player activePlayer){
            //en spelares drag
            bool playerMoveDone = false;
            while(!playerMoveDone){                    
                Console.WriteLine(activePlayer + "?");  

                String userInput = Console.ReadLine();
                //läs in värderna i koordinater.
                int xVal = int.Parse(userInput.Substring(0,1));     
                int yVal = int.Parse(userInput.Substring(1,1));  
                
                //konvertera till arrayvärden. Arraysen börjar ju på 0, inte 1.           
                xVal -= 1;                    
                yVal -=1;

                //om platsen i brädet är ledig
                if(board[xVal,yVal] == 0){
                    //sätt spelarens värde i rutan
                    board[xVal,yVal] = (int)activePlayer;
                    playerMoveDone= true;
                }
            }
        }

        public static void WriteBoard(int[,] board){
            Console.WriteLine("  1 2 3");
            Console.WriteLine(" =======");

            for(int y = 0; y <3; y++){
                Console.Write(y+1 + "|");

                for(int x =0; x < 3; x++){
                    String boardSymbol = " ";
                    if(board[x,y] ==1){
                        boardSymbol ="X";
                    }
                    else if(board[x,y] ==4){
                        boardSymbol ="O";
                    }
                    Console.Write( boardSymbol + "|");
                }
                Console.WriteLine(" \n =======");
            }
        }
        
        public static Boolean playerWon(int[,] board, Player activePlayer){
            for(int i =0; i < 3; i++){
                    //om aktiv spelare vann på x.
                   if(board[i,0]+ board[i,1]+board[i,2] == (int)activePlayer*3){
                       return true;
                       
                   }
                   //om aktiv spelare vann på y.
                   if(board[0,i]+ board[1,i]+board[2,i] == (int)activePlayer*3){
                       return true;                      
                   }
            }

            //om aktiv spelare vann på diagonal
            if(board[0,0] + board[1,1] + board[2,2] ==(int)activePlayer*3){
                return true;
            }
            //om aktiv spelare vann på diagonal
            else if(board[2,0] + board[1,1] + board[2,0] ==(int)activePlayer*3){
                return true;
            }
            return false;
        }
        

         public static Player ChangePlayer(Player activePlayer){
            if(activePlayer.Equals(Player.Ring)){
                return  Player.Kryss;
            }else{
                return  Player.Ring;
            }               
        }


    }
}
