package src;

public class FiveDigitSum {

	public static void main(String[] args) {
        int num = 30458;
        int sum = 0;

        while (num > 0) { 
            sum = sum + (num % 10);
            num = num / 10;
        }
        System.out.println(sum); 
	}
}
