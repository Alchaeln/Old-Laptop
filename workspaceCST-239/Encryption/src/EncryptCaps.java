import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class EncryptCaps {

	public static void main(String[] args) throws IOException {
		
		File file = new File("C:\\Users\\alcha\\OneDrive\\Desktop\\input.in.txt");
		Scanner scan = new Scanner(file);
		String fileContent = "";
		String wordsRandom = "";
		FileWriter writer = new FileWriter("C:\\Users\\alcha\\OneDrive\\Desktop\\result.out.txt");
		
		while(scan.hasNext()) {
			fileContent = scan.next();
			wordsRandom += (fileContent + " "); 
		}
		//Takes String
		//puts into string array

		 String strArray[] = wordsRandom.split(" ");
		
		 for(int i=0; i < strArray.length; i++){
			 writer.write(strArray[i] + "\t\t\t");
			 String tempWord = strArray[i];
			 int arrayLength = (strArray[i].length());
			 
			 
			 if (arrayLength % 2 == 0){
  
				String secondHalf = (tempWord.substring(arrayLength/2));
				String firstHalf = (tempWord.substring(0, tempWord.length() / 2));
				String together = ("" + secondHalf.toUpperCase() + firstHalf.toUpperCase());
			
				writer.write(together + "\n");
				
			 }
			 else if (arrayLength % 2 != 0) {

					String secondHalf = (tempWord.substring((arrayLength + 1)/2));
					String firstHalf = (tempWord.substring(0, (tempWord.length() + 1 )/ 2));
					String together = ("" + secondHalf.toUpperCase() + firstHalf.toUpperCase());
				
					writer.write(together + "\n");
				 
			 }
			 }
		 writer.close();

			 
		//counts the letters in string

		//if even do (n/2) to the end of word
		
		//if odd do (n+1)/2 to the end of the word

	}

}
