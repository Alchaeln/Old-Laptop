import java.util.ArrayList;
import java.util.Random;

public class PlayingCard {
	//properties or variables
	private int value;
	private char suit;
	
	//make value go up from 1-13
	//replace 11 12 13 1 to J Q K A
	//constructor
	PlayingCard (char suit, int value)
	{
	    this.value= value;
	    this.suit= suit;
	}
	
	//getters and setters
	public char getSuit() {
		return suit;}
	
	public int getValue() {
		return value;}
	
	public void setSuit(char suit) {
		this.suit = suit;
	}
	public void setValue(int value) {
		this.value = value;
	}
	
	//puts the value and suit into a string
	public String ToString() {
		String tempValue = "" + value + ""; 
		if (value == 1) {tempValue = "A"; }
		else if(value == 11) {tempValue = "J"; }
		else if(value == 12) {tempValue = "Q"; }
		else if (value == 13){tempValue = "K"; }

		return "(" + tempValue + "," + suit + ")"; 
	}
	//Checks if it is a match
	//if p's suit or value matches is same as called object
	public boolean isMatch(PlayingCard p) {
		if(p.value == this.value || p.suit == this.suit) {
		return true;	
		}
		return false;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//creates an array list 
		ArrayList<PlayingCard> deck = new ArrayList<PlayingCard>(52);
		Random rando = new Random();
		
		
		for (int i = 0; i < 4; i++){
			for(int j = 1; j < 14; j++) {
				char tempSuit = ' ';
				if (i == 0) {tempSuit = 'D'; }
				else if(i == 0) {tempSuit = 'C'; }
				else if(i == 0) {tempSuit = 'H'; }
				else {tempSuit = 'S'; }
				PlayingCard pc = new PlayingCard(tempSuit, j);
				deck.add(pc);
			}
			
		}
		int randomNumber = rando.nextInt(deck.size());
		int randomNumber2 = rando.nextInt(deck.size());
		System.out.println("Random Card " + (deck.get(randomNumber)).ToString());
		System.out.println("Random Card " + (deck.get(randomNumber2)).ToString());
		
		PlayingCard card1 = (deck.get(randomNumber));
		PlayingCard card2 = (deck.get(randomNumber2));
				
		if(card1.isMatch(card2)) {
			System.out.println("Matched!");
		}
		else System.out.println("No Match!");
		
		/* for (PlayingCard pc : deck)
	        {
	           System.out.println(pc.ToString());
	        }
		*/
		
		
		
		
		}
		
	
		

	}

