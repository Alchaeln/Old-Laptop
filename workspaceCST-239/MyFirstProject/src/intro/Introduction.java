package intro;

public class Introduction {
	
	/* private void sayName(String name)
	{
		System.out.println("My name is " + name);
	}
	private void sayColor(String color)
	{
		System.out.println("My favorite color is " + color);
	}
	private void sayLottery(String lottery)
	{
		System.out.println("If I won the lottery, I would "  + lottery);
	}
	*/
	
	public static int mystery2(int n){
		return n/10;
	}
	
	public static void mystery1(int n){
		System.out.println(mystery2(n));
	}
	

	public static void main(String[] args) {
		
		
		int num = 19283;
		mystery1(num);
		//Instantiating a class object called intro
		//Introduction intro = new Introduction();
		//string values
		//intro.sayName("Chael");
		//intro.sayColor("Green");
		//intro.sayLottery("invest half the money"); */
	/*
	
	int sum = 0;
	
	for (int i = 0; i < 10; i ++) {
		for( int j = 0; j< 5; j ++)
			for(int k = 0; k< 2; k++) {
				sum++;
			}
	} */
	//Questio4 
		
/*		char ch = 'y';
		switch(ch) {
		case 'a':
		case 'b':
		case 'c':
			System.out.println("Beg");
			break;
		case 'x':
		case 'y':
		case 'z':
			System.out.println("end");
			break;
			default:
				System.out.println("mid");
		} */
	/* int i = 10;
	while (i<15){
		i--;
	}
		System.out.println(i);
		
		*/
	/*	int number = 33;
		if(number%3 == 0 )
			System.out.println("A");
		if(number%2 == 0 )
				System.out.println("B");
		else
			System.out.println("C");
		*/
		/*int i = 50;
		
		if( i % 2 == 1 ){
			if (i%3 == 0)
				System.out.println("a");
			else
				System.out.println("b");
		}else {
			if (i%3 == 0)
				System.out.println("C");
			else
				System.out.println("D");
		}
		
	/*
	ArrayList<String> mylist = new ArrayList<String>();
	mylist.add("Xray");
	mylist.add("YEllow");
	mylist.add("Zing");
	
	System.out.println(mylist.get(0).charAt(2));
	}


		int[]vals = {0, 2,4,6,8};
		int index = 2;
		vals[index]++;
		System.out.println(vals[index]);
		
		String s = "What we think, we become";
		String s1 = s.substring(5);
		String s2 = s1.substring(3);
		
		System.out.println(s2);
		
		int[][] sales = new int[4][3];
		for(int row = 0;row <4; row++) {
			for(int col = 0; col <3; col++) {
				sales[row][col] = 100 + row*col;
			}
		}
		System.out.println(sales[3][2]);
		
		
		char[] myChars = {'a','$','^','A'};
		System.out.println(myChars);
		
		
String str = "Antelope Country";
String mystery = "";
for(int i = 0; i <str.length(); i++)
	mystery = str.charAt(i) + mystery;
System.out.println(mystery);

*/

		
		
		
	}
}
