using Game1.Services;
using Game1.Support;
using System;

namespace Game1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			var gameService = new GameService();
			gameService.StartGame();
			Console.ReadLine();
		}
	}
}
