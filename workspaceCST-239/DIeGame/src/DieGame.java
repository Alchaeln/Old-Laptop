import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class DieGame {
	
	private int value;
	
	//constructor
	
	DieGame (int value){
		this.value = value;
	}
	
	//getters and setters
	public int getValue() {
		return value;
	}

	public void setValue(int value) {
		this.value = value;
	}
	
	//toString Method
	public String ToString() {
		return "" + value + "";
	}
	
	//driver method
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		ArrayList<String> Dice = new ArrayList<String>(5);
		Random rando = new Random();
		int rolls = 100000;
		int threeOfKinds = 0;
		int fourOfKinds = 0;
		int fiveOfKinds = 0;
		
		//for loop to go through rolling the array of 5 dice x amount of times
		
		 for(int i = 0; i <= rolls; i++) {
			//System.out.println("Roll number: " + i);
			for(int j = 0; j < 5; j++ ) {
				int randomNumber = rando.nextInt(6 + 1 - 1) + 1;
				DieGame dg = new DieGame(randomNumber);
			
			//System.out.println(dg.ToString());
				
				Dice.add(dg.ToString());
				
			}
			
			//if statements to see how frequent these 3/4/5 of a kinds appear
			
			if (Collections.frequency(Dice, "1") == 3 || Collections.frequency(Dice, "2") == 3 || Collections.frequency(Dice, "3") == 3 || Collections.frequency(Dice, "4") == 3
				|| Collections.frequency(Dice, "5") == 3 || Collections.frequency(Dice, "6") == 3) {
				++threeOfKinds;
			}
			if (Collections.frequency(Dice, "1") == 4 || Collections.frequency(Dice, "2") == 4 || Collections.frequency(Dice, "3") == 4 || Collections.frequency(Dice, "4") == 4
					|| Collections.frequency(Dice, "5") == 4 || Collections.frequency(Dice, "6") == 4) {
					++fourOfKinds;
				}
			if (Collections.frequency(Dice, "1") == 5 || Collections.frequency(Dice, "2") == 5 || Collections.frequency(Dice, "3") == 5 || Collections.frequency(Dice, "4") == 5
					|| Collections.frequency(Dice, "5") == 5 || Collections.frequency(Dice, "6") == 5) {
					++fiveOfKinds;
				}
			
			
			//System.out.println(Dice);
			
			//clears array of 5
			Dice.clear();
		}
		 
		 //prints info you need to see
	 System.out.println("In " + rolls + " rolls you obtained");
	 System.out.println("This many Three of a Kinds: " + threeOfKinds);
	 System.out.println("This many Four of a Kinds: " + fourOfKinds);
	 System.out.println("This many Five of a Kinds: " + fiveOfKinds);
		 
		
		
		
		

	}



	
}
