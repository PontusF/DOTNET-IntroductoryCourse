using System;

class GraphicalEngine{
    String empty = "▢";

    public void drawBoard(Board board){
        int uBound0 = board.getBoardData().GetUpperBound(0);
        int uBound1 = board.getBoardData().GetUpperBound(1);
        Console.Write("  X ");
        for(int x = 0; x <= uBound1; x++){
            String spaces ="  ".Substring((x+1).ToString().Length -1);
            Console.Write(x+1 + spaces);
        }

        Console.Write("\n");
        Console.Write( "Y-  ");

        for(int x = 0; x <= uBound1 ; x++){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write( " ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write( "  ");
        }
        Console.ResetColor();

        Console.Write("\n");
        for(int x = 0; x <= uBound0 ; x++){

            String spaces ="  ".Substring((x+1).ToString().Length -1);
            Console.Write( x+1);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("-" + spaces);
            Console.ResetColor();

            for ( int y = 0; y <= uBound1; y++){
                Square square = (Square)board.getBoardData().GetValue(x,y);
                Console.Write(SymbolicRepresentation(square) + "  ");
                Console.ResetColor();
            }
            Console.Write("\n");
        }
        

    }

    private String SymbolicRepresentation(Square square){
        if(!square.isrevealed()){
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return "■";
           // return "■";
        }

        if(square.ismine()){
            return "X";
              //  return "֎";
        }
        if(square.getAmountOfAdjacent() > 0 ){
            Console.ForegroundColor = AdjColor(square.getAmountOfAdjacent());
            return square.getAmountOfAdjacent().ToString();
        }
        
        return " ";
        //return empty;
        
    }

    private ConsoleColor AdjColor(int amountOfAdjacent){
        switch(amountOfAdjacent){
            case 1:
                return ConsoleColor.Blue;
            case 2: 
                return ConsoleColor.DarkGreen;
            case 3:
                return ConsoleColor.Red;
            case 4:
                return ConsoleColor.DarkBlue;
            case 5:
                return ConsoleColor.DarkRed;
            case 6:
                return ConsoleColor.DarkCyan;
            case 7:
                return ConsoleColor.Black;
            case 8:
                return ConsoleColor.Gray;
        }
        return ConsoleColor.Magenta;
    }


}