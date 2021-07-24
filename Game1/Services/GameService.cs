using Game1.Players;
using Game1.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Services
{
	public class GameService
	{
		private List<Point> _points = new List<Point>
		{
			new Point(1, 1), new Point(1, 3), new Point(1, 5),
			new Point(3, 1), new Point(3, 3), new Point(3, 5),
			new Point(5, 1), new Point(5, 3), new Point(5, 5),
		};

		private List<PlayerBase> _players = new List<PlayerBase>
		{ new HumanPlayer('X'), new HumanPlayer('O') };

		public void StartGame()
		{
			ConsoleManager.ShowMap(_points);
			while (true)
			{
				foreach (var player in _players)
				{
					var index = player.GetWontedIndex(GetAvailableIndexes());

					ApplyIndex(index, player.Code);

					ConsoleManager.ShowMap(_points);

					if (GetAvailableIndexes().Count == 0)
					{
						Console.WriteLine("Игра закончена!");
						return;
					}
					else if (CheckEndOfGame())
					{
						Console.WriteLine($"Игрок {player.Code} победил!");
						return;
					}
				}
			}
		}

		private void ApplyIndex(int index, char code)
		{
			_points[index].OwnerCode = code;
		}

		private List<int> GetAvailableIndexes()
		{
			var result = new List<int>(_points.Count);
			foreach (var point in _points)
				if (point.IsAvailable)
					result.Add(IndexMapper.PointToIndex[point]);

			return result;
		}

		private bool CheckEndOfGame()
		{
			return IsRowWin() || IsDiagWin() || IsColumnWin();
		}

		private bool IsRowWin()
		{
			return IsCodesEquals(0, 1, 2)
				|| IsCodesEquals(3, 4, 5)
				|| IsCodesEquals(6, 7, 8);
		}

		private bool IsColumnWin()
		{
			return IsCodesEquals(0, 3, 6)
				|| IsCodesEquals(1, 4, 7)
				|| IsCodesEquals(2, 5, 8);
		}

		private bool IsDiagWin()
		{
			return IsCodesEquals(0, 4, 8)
				|| IsCodesEquals(6, 4, 2);
		}

		private bool IsCodesEquals(params int[] indexes)
		{
			var firstCode = _points[indexes[0]].OwnerCode;

			if (firstCode == default(char))
				return false;

			foreach (var index in indexes)
				if (firstCode != _points[index].OwnerCode)
					return false;

			return true;
		}
	}
}
