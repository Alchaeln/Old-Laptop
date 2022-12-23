package intro;

public class Introduction {
	
	private void sayName(String name)
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
	

	public static void main(String[] args) {
		//Instantiating a class object called intro
		Introduction intro = new Introduction();
		//string values
		intro.sayName("Chael");
		intro.sayColor("Green");
		intro.sayLottery("invest half the money");
		
	}

}
