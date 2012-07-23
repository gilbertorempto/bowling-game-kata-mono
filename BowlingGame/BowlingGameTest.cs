using System;
using NUnit.Framework;

namespace BowlingGame
{
	[TestFixture()]
	public class BowlingGameTest
	{
		private Game g;

		private void RollMany (int n, int pins)
		{
			for (int i = 0; i < n; i++)
				g.Roll(pins);
		}

		[SetUp]
		protected void SetUp ()
		{
			g = new Game();
		}

		[Test()]
		public void TestGutterGame ()
		{
			RollMany(20, 0);
			Assert.AreEqual(0, g.Score);
		}

		[Test()]
		public void TestAllOnes ()
		{
			RollMany(20, 1);
			Assert.AreEqual(20, g.Score);
		}
	}
}

