using System;

public class Program
{

	public class Numbers
	{	
		public int Number;
		
		public Number()
		{
		}
		
		public Number(int num)
		{
			Number = num;
		}
	}
	
	
	public static void Main()
	{
		Number myNum = new Number(){Number = 1};
		Number myNum2 = new Number(5);
		
		myNum.DoubleIt();
		myNum2.TripleIt();		
	}


}
public static class Operators
	{
		public static int DoubleIt(this int num)
		{
			return num * 2; 
		}
		
		public static int TripleIt(this int num) => num*3;
	}
	// Extension Methods must be static inside a static class.
	