using System;
using NUnit.Framework;

namespace BowlingGame
{
	[TestFixture()]
	public class BowlingGameTest
	{
		[Test()]
		public void TestGutterGame ()
		{
			Game g = new Game();
			for (int i = 0; i < 20; i++)
				g.Roll(0);
			Assert.AreEqual(0, g.Score);
		}
	}
}

