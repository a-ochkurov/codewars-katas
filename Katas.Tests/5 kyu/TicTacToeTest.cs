using System;
using NUnit.Framework;

[TestFixture]
public class TicTacToeTest {
	private TicTacToe tictactoe = new TicTacToe();
  
	[Test]
	public void test1() {
		int[,] board = new int[,] { { 2, 1, 1 }, { 2, 1, 2 }, { 2, 0, 0 } };
    Assert.AreEqual(2, tictactoe.IsSolved(board));
	}
}