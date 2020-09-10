public class Square{
    private bool mine = false;
    private bool revealed = false;
    private int amountOfAdjacent = 0;

    private int[] coordinates;

    public int[] getCoordinates()
    {
        return this.coordinates;
    }




    public Square(int x, int y){
		coordinates = new int[]{x,y};
	}

	public bool ismine() {
		return this.mine;
	}

	public void setmine(bool mine) {
		this.mine = mine;
	}

	public bool isrevealed() {
		return this.revealed;
	}

	public void setrevealed(bool revealed) {
		this.revealed = revealed;
	}

	public int getAmountOfAdjacent() {
		return this.amountOfAdjacent;
	}

	public void setAmountOfAdjacent(int amountOfAdjacent) {
		this.amountOfAdjacent = amountOfAdjacent;
	}


    


}