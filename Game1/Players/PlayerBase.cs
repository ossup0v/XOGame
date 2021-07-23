using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Players
{
	public abstract class PlayerBase
	{
		public PlayerBase(char code) { Code = code; }

		public char Code { get; protected set; }

		public abstract int GetWontedIndex(List<int> avaialbeIndexes);
	}
}
