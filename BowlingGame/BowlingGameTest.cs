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

		private void RollSpare ()
		{
			g.Roll(5);
			g.Roll(5);
		}

		private void RollStrike ()
		{
			g.Roll(10);
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

		[Test()]
		public void TestOneSpare ()
		{
			RollSpare();
			g.Roll(3);
			RollMany(17, 0);
			Assert.AreEqual(16, g.Score);
		}

		[Test()]
		public void TestOneStrike ()
		{
			RollStrike();
			g.Roll(3);
			g.Roll(4);
			RollMany(16, 0);
			Assert.AreEqual(24, g.Score);
		}
	}
}

