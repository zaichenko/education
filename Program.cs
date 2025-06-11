using System;
namespace education
{


	public class Program
	{
		public static void Test1(Fox forestfox)
		{
			string t = forestfox.Run(-10);
			if (t != "fox do not running")
			{
				Console.WriteLine("Test1 - error");
			}
		}
		public static void Test2(Fox forestfox)
		{
			string t = forestfox.Run(10);
			if (t != "fox running 10 km")
			{
				Console.WriteLine("Test2 - error");
			}
		}
		public static void Test3(Fox forestfox)
		{
			string t = forestfox.Run(0);
			Console.WriteLine(t);
			if (t != "fox do not running")
			{
				Console.WriteLine("Test3 - error");
			}
		}
		static int g;

		public static void Omeo()
		{
			Fox.AddBinary(-10, 20);
			Console.WriteLine();
			//forestfox.Output(t);
		}
	}
}
