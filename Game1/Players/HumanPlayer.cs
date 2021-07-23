using Game1.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Players
{
	public class HumanPlayer : PlayerBase
	{
		public HumanPlayer(char code) : base(code) { }

		public override int GetWontedIndex(List<int> avaialbeIndexes)
		{
			while (true)
			{
				Console.SetCursorPosition(0, 7);
				var wonted = Console.ReadLine();
				Console.SetCursorPosition(0, 7);
				Console.WriteLine("        ");
				Console.WriteLine("                                         ");
				var splitedStr = wonted.Split(' ');
				var splitedInt = new int[splitedStr.Length];

				for (int i = 0; i < splitedInt.Length; i++)
					splitedInt[i] = Convert.ToInt32(splitedStr[i]);

				var index = IndexMapper.PointToIndex[new Point(splitedInt[0], splitedInt[1])];

				if (avaialbeIndexes.Contains(index))
					return index;

				Console.SetCursorPosition(0, 8);
				Console.WriteLine("Вы не можете захватить эту точку!");
			}
		}
	}
}
