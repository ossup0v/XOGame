using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Players
{
	public class ComputerPlayer : PlayerBase
	{
		public ComputerPlayer(char code) : base(code) { }

		private Random r = new Random();
		public override int GetWontedIndex(List<int> avaialbeIndexes)
			=> avaialbeIndexes[r.Next(0, avaialbeIndexes.Count)];
	}
}
