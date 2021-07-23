using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Support
{
	public class ConsoleManager
	{
		public static void ShowMap(List<Point> points)
		{
			foreach (var point in points)
			{
				Console.SetCursorPosition(point.X, point.Y);
				Console.Write(point.OwnerCode);
			}

			ShowMapOutLine();
		}

		private static void ShowMapOutLine()
		{
			for (int i = 0; i < 4; i++)
				Show(i * 2, 7, 1, '|');

			for (int i = 1; i < 6; i += 2)
				Show(i, 4, 2, '-');
		}

		private static void Show(int XStartIndex, int count, int gap, char code)
		{
			for (int i = 0; i < count; i++)
			{
				Console.SetCursorPosition(XStartIndex, i * gap);
				Console.WriteLine(code);
			}
		}
	}
}
