/*<<<<<<< HEAD
werrasdwereDFcvbvcsd
asdDFcvbvcfhfghsd
sadfsadfsaxVsDvsd
sadfsadfter t
dfgdsfgadergertgerапрвапр
вкерваер

fgdghfghfghf
--change by Andrey--
12345
dghdsdsdgjsgsg
faeefafjlnafjnajfnakjfhaukhfeaaaaaafu
-----
----
---
--
-
улица фонарь аптека
андрей вспомнил парольшекщ4ш
почему нет конфликта?????
потому что я бэтмен
ты дурила
дурила - твое второе имя <3
это в горах тебя научили так махаться? жесть
это что получается, у тебя по субботам оффлайная жизнь, а на будних онлайн
kak dela-_-
poshla von dura
abracadabra
=======
restart project...
please, ne zasoryaite file!
>>>>>>> a84b17b5a9733e8d062b206f00aeb8e25a71bcf0
*/

using System;

				
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
	static int g;
	
	public static void Main()
	{
		Fox forestfox = new Fox();
		forestfox.Eat();
		Test1(forestfox);
		Test2(forestfox);
		Test3(forestfox);
		Console.WriteLine();
		//forestfox.Output(t);
	}
}

public class Fox
{
	public string Run(int distance)
{
	switch (distance)
	{
		case <= 0:
		return "fox do not running";
		break;
		case <= 10:
		return "fox running " + distance + " km";
		break;
		default:
		return "fox do not running"; 
		break;
	
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
