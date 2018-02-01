using System;

namespace DotNetCore.Cons
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			Console.WriteLine($"Hello{ System.Environment.GetEnvironmentVariable("USER")}!I'm {System.Environment.MachineName} and I'm talkingto you from { System.IO.Directory.GetCurrentDirectory()}");
			Console.ReadKey();
		}
	}
}
