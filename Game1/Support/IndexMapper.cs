using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Support
{
	public static class IndexMapper
	{
		public static Dictionary<int, Point> IndexToPoint = new Dictionary<int, Point>
		{ 
			[0] = new Point(1, 1), [1] = new Point(1, 3), [2] = new Point(1, 5),
			[3] = new Point(3, 1), [4] = new Point(3, 3), [5] = new Point(3, 5),
			[5] = new Point(5, 1), [6] = new Point(5, 3), [8] = new Point(5, 5)
		};

		public static Dictionary<Point, int> PointToIndex = new Dictionary<Point, int>
		{
			[new Point(1, 1)] = 0, [new Point(1, 3)] = 1, [new Point(1, 5)] = 2,
			[new Point(3, 1)] = 3, [new Point(3, 3)] = 4, [new Point(3, 5)] = 5,
			[new Point(5, 1)] = 6, [new Point(5, 3)] = 7, [new Point(5, 5)] = 8
		};
	}
}
