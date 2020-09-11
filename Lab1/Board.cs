

using System;
using System.Collections.Generic;


public class Board{
    //x, y
    private int[] dimensions;

    private int amountOfMines;
    private Square[,] boardData;
    
    private List<Square> mines = new List<Square>();

    private int amountOfRevealed = 0;

    public Board(int[] dimensions, int amountOfMines){
        this.amountOfMines = amountOfMines;
        this.dimensions = dimensions;
        boardData = new Square[dimensions[0], dimensions[1]];

        for(int x = 0; x < dimensions[0]; x++){
            for (int y = 0; y < dimensions[1]; y++){
                boardData[x, y] = new Square(x,y);
            }
        }
        populateAllMines();
        populateAdjacencies();
    }
    public Square[,] getBoardData(){
        return boardData;
    }

    private void populateAllMines(){
        Random random = new Random();
        
        for(int i = 0; i < amountOfMines; i++){
                bool spaceOccupied = true;
                while(spaceOccupied){

                    int xPos = random.Next(0,dimensions[0]);
                    int yPos = random.Next(0,dimensions[1]);

                    if(!isMine(xPos,yPos)){
                        spaceOccupied = false;
                        boardData[xPos,yPos].setmine(true);
                        mines.Add((Square)boardData.GetValue(xPos, yPos));                        
                    }                    
                }
        }
    }

    private void populateAdjacencies(){
        
        //this loop is for mines
        foreach(Square square in mines){
            Square[] adj = adjacentSquares(square.getCoordinates());
            
            //this loop is for all around a mine
            foreach(Square adjacentToMine in adj){
                if(!adjacentToMine.ismine()){
                    Square[] aroundTheNonMine = adjacentSquares(adjacentToMine.getCoordinates());
                    adjacentToMine.setAmountOfAdjacent(calcAdjForOne(aroundTheNonMine));
                }
            }
        }
    }

    public int guess(int[] coordinates){
        Square inspectedSquare = (Square)boardData.GetValue(coordinates);
        if(inspectedSquare.ismine()){
            revealBoard();
            return -1;
        }
        ExecuteRevealRipple(inspectedSquare);
        return 0;
    }

    public void ExecuteRevealRipple(Square initial){
        Console.WriteLine("ripple started");

        revealSquare(initial);
        Square[] adjacent = adjacentSquares(initial.getCoordinates());

        foreach(Square square in adjacent){       
            if( isHiddenBlank(square)){
                ExecuteRevealRipple(square);
            }
            else if( !square.ismine() && !square.isrevealed() && isBlank(initial)){
                revealSquare(square);
            }
        }
    }

    private void revealSquare(Square square){
        if(square.isrevealed()){    return; }
            amountOfRevealed++;
            square.setrevealed(true);
            if (isGameWon()){
                Console.WriteLine("YOU WON WOOOOHPIE");
            }
    }

    private bool isGameWon(){
        Console.WriteLine("DEBUG SQ: " + dimensions[0]*dimensions[1]  +". Mines: " + amountOfMines + ". Revealed: " + amountOfRevealed);
        return dimensions[0]*dimensions[1] - amountOfMines == amountOfRevealed;
    }

    private bool isBlank(Square square){
        return !square.ismine() && square.getAmountOfAdjacent() == 0;
    }

    private bool isHiddenBlank(Square square){
        return isBlank(square) && !square.isrevealed();
    }

    private void revealBoard(){
        for(int x = 0; x < dimensions[0]; x++){
            for (int y = 0; y < dimensions[1]; y++){                
                revealSquare(boardData[x, y]);
            }
        }
    }

    private int calcAdjForOne(Square[] adjacentSquares){
        int adjecentMines = 0;

        foreach(Square square in adjacentSquares){
            if(square.ismine()){
                adjecentMines++;
            }
        }
        return adjecentMines;
    }

    public Boolean isMine(int x, int y){
        return boardData[x,y].ismine();
    }

    private Square[] adjacentSquares(int[]coordinates){
        int x= coordinates[0];
        int y = coordinates[1];
        List<int[]> adjacentSquares = new List<int[]>();

        /*  x->
                | 0 | 1 | 2 |           
            y   | 3 |   | 4 |            
            |   | 5 | 6 | 7 |
            v
        */

      

        adjacentSquares.Add( new int[]{x-1, y -1}); // index 0
        adjacentSquares.Add( new int[]{x, y-1});    // index 1
        adjacentSquares.Add( new int[]{x+1, y-1});  // index 2
        adjacentSquares.Add( new int[]{x-1, y});    // index 3
        adjacentSquares.Add( new int[]{x+1, y});    // index 4
        adjacentSquares.Add( new int[]{x-1,y+1});   // index 5
        adjacentSquares.Add( new int[]{x, y+1});    // index 6
        adjacentSquares.Add( new int[]{x+1, y+1});  // index 7

        for(int i = 7; i > -1; i--){
            if(isOutOfBounds(adjacentSquares[i][0],adjacentSquares[i][1])){
                adjacentSquares.RemoveAt(i);
            }
        }
        Square[] adjSquares = new Square[adjacentSquares.Count];
        
        for(int i = 0; i < adjacentSquares.Count; i++ ){
            adjSquares[i] = boardData[adjacentSquares[i][0],adjacentSquares[i][1]];
        }
         return adjSquares;

    }

    private bool isOutOfBounds(int x, int y){
        return (x < 0 || x >= dimensions[0] || y <0 || y >= dimensions[1]);
       // if(x < 0 || x >= dimensions[0] || y <0 || y >= dimensions[1]){
       //     return true;
       // }
       // return false;
    }


}