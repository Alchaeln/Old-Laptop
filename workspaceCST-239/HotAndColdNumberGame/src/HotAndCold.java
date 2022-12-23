import java.util.Random;
import java.util.Scanner;

public class HotAndCold {
    public static void main(String[] args) {
		int min = 1;
		int max = 10000;

		Random random = new Random();

		int value = random.nextInt(max + min) + min; //number to guess
		
		System.out.println("Enter a number between " + min + " and " + max);
		Scanner scan= new Scanner(System.in); 
		int userNum;
		//scan user input
	
		//while loop checks if user input is equal to the random number
		while((userNum = scan.nextInt()) != value) {		
			
			if (userNum < value && userNum < max && userNum > min) {
				System.out.println("Higher");
				
				min = userNum; 
				
			}

			else if (userNum > value && userNum < max && userNum > min){
				System.out.println("Lower");
				
				max = userNum;
				
			}
			
			
			System.out.println("Enter a number between " + min + " and " + max);
			
		}
		System.out.println("Winner!");
		
    }
    
}
