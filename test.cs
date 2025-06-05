

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

				
public class Program	
{
	public static void Test1(Fox forestfox)
	{
		string t = forestfox.Run(-10);
		if (t != "fox do not running")
		{
			Console.WriteLine ("Test1 - error");
		}
	}
	public static void Test2(Fox forestfox)
	{
		string t = forestfox.Run(10);
		if (t != "fox running 10 km")
		{
			Console.WriteLine ("Test2 - error");
		}
	}
	public static void Test3(Fox forestfox)
	{
		string t = forestfox.Run(0);
		Console.WriteLine (t);
		if (t != "fox do not running")
		{
			Console.WriteLine ("Test3 - error");
		}
	}
	
	public static void Main()
	{
		Loop loop = new Loop();
		loop.Testloop();

        
        

        
		
		
        Console.WriteLine();
		Console.ReadLine();
		//forestfox.Output(t);
	}
}

public class Fox
{
	public string Run(int distance)
	{
		if (distance <=0)
		{
			return "fox do not running";
		}
		else if (distance <=10)
		{
			return "fox running " + distance + " km";
		}
		else
		{
			return "fox do not running";
		}
		return "";
	}
public void Eat()
{
Console.WriteLine("fox eating");
}
public void Output (string red)
	{		
Console.WriteLine (red);
	}

}
public class Loop
{
	public void Testloop()
	{
        /*(for (int i = 10; i >= 1; i--)
		{
			Console.WriteLine(i);
		}
		int j = 10;
		do
		{
			Console.WriteLine(j);
			j--;
		}
		while (j >= 1); 

		int y = 10;
		while (y >= 1)
			{
			Console.WriteLine(y);
				y--; 
			} */
        int[] nums10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Array.Reverse (nums10);
        foreach (int c in nums10)
		{ 
			Console.WriteLine(c); 
		}
        Array.Reverse (nums10);
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(nums10[i]);
        }
		
    }
}