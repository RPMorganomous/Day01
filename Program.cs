using System;
using System.IO;

namespace ConsoleApplication1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("devan should play with me");
			
			StreamReader myReader = new StreamReader("D:\\developement\\Advent2018\\Day01\\files\\day01input.txt");
			string line = "";
			int num = 0;

			while (line != null)
			{
				line = myReader.ReadLine();
				if (line!= null)
					Console.WriteLine(line);
					num = num + Convert.ToInt32(line);
					Console.WriteLine(num);

			}
			myReader.Close();
			Console.WriteLine("done = " + num);
			Console.ReadLine();
			
		}
	}
}