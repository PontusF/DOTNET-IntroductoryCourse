using System;

namespace testing
{
    class Program
    {
        enum Player{
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

               //Rita ut brädet.
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
               
                
               //en spelares drag
               bool waitingForPlayerInput = true;
                while(waitingForPlayerInput){                    
                    Console.WriteLine(activePlayer + "?");                    

                    String userInput = Console.ReadLine();
                    //läs in värderna i koordinater.
                    int xVal = int.Parse(userInput.Substring(0,1));                  
                    xVal -= 1;
                    int yVal = int.Parse(userInput.Substring(1,1));
                    yVal -=1;

                    //om platsen i brädet är ledig
                    if(board[xVal,yVal] == 0){
                        //sätt spelarens värde i rutan
                        board[xVal,yVal] = (int)activePlayer;
                        waitingForPlayerInput= false;
                    }
                }

                for(int i =0; i < 3; i++){
                    //om aktiv spelare vann på x.
                   if(board[i,0]+ board[i,1]+board[i,2] == (int)activePlayer*3){
                       gameActive = false;
                       break;
                   }
                   //om aktiv spelare vann på y.
                   if(board[0,i]+ board[1,i]+board[2,i] == (int)activePlayer*3){
                       gameActive = false;
                       break;
                   }
                }

                if(gameActive){
                    //om aktiv spelare vann på diagonal
                    if(board[0,0] + board[1,1] + board[2,2] ==(int)activePlayer*3){
                        gameActive = false;
                    }
                    //om aktiv spelare vann på diagonal
                    else if(board[2,0] + board[1,1] + board[2,0] ==(int)activePlayer*3){
                        gameActive = false;
                    }
                }

                if(gameActive){
                    //byt aktiv spelare.
                    if(activePlayer.Equals(Player.Ring)){
                        activePlayer = Player.Kryss;
                    }else{
                        activePlayer = Player.Ring;
                    }
                }                
           }
           Console.WriteLine(activePlayer + " vann!");

        }    
    }
}
