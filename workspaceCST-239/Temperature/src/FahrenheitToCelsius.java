import java.util.Scanner;

public class FahrenheitToCelsius {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc= new Scanner(System.in); 
		
		System.out.print("Enter Celsius number: ");  
		double C = sc.nextDouble();
		double fahrenheit = C*9/5 + 32;
		System.out.printf("%.2fC is equivalent to %.3fF\n", C , fahrenheit ); 
		
		
		System.out.print("Enter Fahrenheit number: "); 
		double F = sc.nextDouble();
		double celsius = (F - 32) * 5/9;
		System.out.printf("%.2fF is equivalent to %.3fC\n" , F , celsius); 

	}
		

}
