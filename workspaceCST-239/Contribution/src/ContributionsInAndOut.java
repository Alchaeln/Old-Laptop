import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class ContributionsInAndOut {

	public static void main(String[] args) throws IOException {
		File file = new File("C:\\Users\\alcha\\OneDrive\\Desktop\\$20.txt");
		Scanner scan = new Scanner(file);
		
		String fileContent = "";
		double addMe = 0.00;
		double total = 0.00;
		double ctr = 0;
		double neededAmount = 10000000.00;
		ArrayList<Double> arr1 = new ArrayList<Double>();
		
		while(scan.hasNextLine())
		{
		    fileContent = scan.nextLine(); //scans every number first and transfer them into an int 
		  	double i = Double.parseDouble(fileContent);
			
			arr1.add(i); //puts all info into an array
			
			total = addMe += i; //Adds all numbers
			
			ctr ++;
		}
		
		
		//gets min, max, and average
		double min = Collections.min(arr1);
		double max = Collections.max(arr1);
		double avg = 0.00;
		double sum = 0;
		
		for (int i = 0; i < arr1.size(); i++) {
            sum = sum + arr1.get(i);
            avg = sum / arr1.size();
		}
		
		FileWriter writer = new FileWriter("C:\\Users\\alcha\\OneDrive\\Desktop\\NewFile.txt");
		
		
		//after does an if statement to check if equal to 10,000,000
		if(total < neededAmount) {
			String ifNotTrue = String.format("It took %.0f contributions to reach $%.2f\n"
					+ "The maximum contribution received was $%.2f\n"
					+ "The minimum contribution received was $%.2f\n"
					+ "The average contribution amount was $%.2f\n"
					+ "A total of $%.2f was collected", ctr, total, max, min, avg, total);	
			
			writer.write(ifNotTrue);
		}
		
		else {
			String ifTrue = String.format("It took %.0f contributions to reach the goal\n"
					+ "The maximum contribution received was $%.2f\n"
					+ "The minimum contribution received was $%.2f\n"
					+ "The average contribution amount was $%.2f\n"
					+ "A total of $%.2f was collected", ctr, max, min, avg, total);		
			
			writer.write(ifTrue);
		}
		
		writer.close();

		

	}

}
