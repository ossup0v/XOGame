using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Support
{
	public class Point
	{
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public char OwnerCode { get; set; } = default(char);
		public int X { get; set; }
		public int Y { get; set; }

		public bool IsAvailable => OwnerCode == default(char);

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (obj is Point point)
				return point.X == X && point.Y == Y;

			return false;
		}

		public override int GetHashCode()
		{
			return X.GetHashCode() ^ Y.GetHashCode();
		}
	}
}
