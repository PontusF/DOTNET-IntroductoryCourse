using System;

class GraphicalEngine{
    String empty = "▢";

    public void drawBoard(Board board){
        int uBound0 = board.getBoardData().GetUpperBound(0);
        int uBound1 = board.getBoardData().GetUpperBound(1);
        Console.Write("   X ");
        for(int x = 0; x <= uBound0 ; x++){
            Console.Write(x+1 + "  ");
        }
        Console.Write("\n");
        Console.Write( "Y-  ");
        for(int x = 0; x <= uBound0 ; x++){
            Console.Write( "- ");
        }
        Console.Write("\n");
        for(int x = 0; x <= uBound0 ; x++){

            Console.Write( x+1 +" -  ");
            for ( int y = 0; y <= uBound1; y++){
                Square square = (Square)board.getBoardData().GetValue(x,y);
                Console.Write(SymbolicRepresentation(square) + "  ");
            }
            Console.Write("\n");
        }
        

    }

    private String SymbolicRepresentation(Square square){
        if(!square.isrevealed()){
            return "O";
           // return "■";
        }

        if(square.ismine()){
            return "X";
              //  return "֎";
        }
        if(square.getAmountOfAdjacent() > 0 ){
            return square.getAmountOfAdjacent().ToString();
        }
        return "_";
        //return empty;
        
    }
}