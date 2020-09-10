using System;

class GameEngine{
    private bool gameInSession = false;
    private GraphicalEngine graphics;

    public GameEngine(){
        graphics = new GraphicalEngine();
    }
    public void newGame(){
       
        Board board = new Board(new int[]{4,4}, 4);
        graphics.drawBoard(board);
        gameInSession = true;
        while(gameInSession){
            

            int[] nextGuess = userInputCoordinates();
            int feedBack = board.guess(nextGuess);
            if(feedBack == -1){
                graphics.drawBoard(board);
                Console.WriteLine("GAME OVER NOOB");
                break;
            }
            graphics.drawBoard(board);
        }
    }
    private int[] userInputCoordinates(){
        int x;
        int y;

        Console.WriteLine("input x value");
        String yString = Console.ReadLine();
        y = Int32.Parse(yString);

        Console.WriteLine("input y value");
        String xString = Console.ReadLine();
        x = Int32.Parse(xString);
        return new int[]{x-1,y-1};
    } 
}