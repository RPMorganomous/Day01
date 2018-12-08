using System;
using System.IO;

namespace ConsoleApplication1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("howdy, y'all");
			
			StreamReader myReader = new StreamReader("D:\\developement\\Advent2018\\Day01\\files\\day01input.txt");
			string line = "";

			while (line != null)
			{
				line = myReader.ReadLine();
				if (line!= null)
					Console.WriteLine(line);
			}
			myReader.Close();
			Console.WriteLine("done");
			Console.ReadLine();
			
		}
	}
}