import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class EncryptArray {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		int rows = 4;
		int columns = 8;
		
		File file = new File("C:\\Users\\alcha\\OneDrive\\Desktop\\input.in.txt\\");
		Scanner scan = new Scanner(file);
		String fileContent = "";
		String words = "";
		
		while(scan.hasNext()) {
			fileContent = scan.next();
			words += (fileContent + " "); 
		}
		
		char[][] encryptArray = new char[rows][columns];

		//make 2D array that is 4 by 8
		//take words characters and insert each char into the array
		char[] charWords = words.toCharArray(); 
		//input them row by row
		int len = words.length();
		boolean empty = false;
		int currentLetter = 0;
		for (int row = 0;row < rows; row++)
        {
			for(int col = 0; col < columns; col++)
			{
				
				if(row % 2 != 0 ) {
					encryptArray[row][(columns - 1) - col] = charWords[currentLetter];
				}
				
				else {encryptArray[row][col] = charWords[currentLetter];}
				
				currentLetter++;
				
				if(currentLetter >= len)
				{
					empty = true;
					break;
				}
			}
			if(empty)
			{
				break;
			}
			
         }
	
		for (int col = 0; col < columns; col++)
        {
			for(int row = 0;row < rows; row++)
			{
				System.out.print(encryptArray[row][col]);
			}
        }

	}
		//Have grid of words then
		//go down each column and create encrypted text
}
