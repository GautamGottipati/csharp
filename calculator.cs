using System;
					
public class Program
{
	public static void Main()
	{
		int a,b;
		String op;
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
		op = Console.ReadLine();
		if(op == "+")
			Console.WriteLine(a+b);
		else if(op == "*")
			Console.WriteLine(a*b);
		else if(op == "/")
			Console.WriteLine(a/b);
		else if(op == "-")
			Console.WriteLine(a-b);
		else
			Console.WriteLine("Invalid Operator !");
		
	}
}
