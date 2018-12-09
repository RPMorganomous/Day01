using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

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
			List<int> theList = new List<int>();
			var alreadyInTheList = false;

			while (!alreadyInTheList)
			{
				while (line != null)
				{
					line = myReader.ReadLine();
					if (line != null)
						{
						Console.WriteLine(line);
						num = num + Convert.ToInt32(line);
						Console.WriteLine(num);
						alreadyInTheList = theList.Contains(num);
						if (alreadyInTheList)
							{
								Console.WriteLine("alreadyInTheList done = " + num + line);
								break;
							}
						theList.Add(num);
						}
					//line = "";	
					//alreadyInTheList = false;				
				}
				myReader = new StreamReader("D:\\developement\\Advent2018\\Day01\\files\\day01input.txt");
				line = "";
			}

			myReader.Close();
			Console.WriteLine("done = " + num + line);
			//Console.ReadLine();
			
		}
	}
}