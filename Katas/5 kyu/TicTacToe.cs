using System;
using System.Linq;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    for (int i = 0; i < 3; i++)
    {
      var rows = board[i, 0] & board[i, 1] & board[i, 2];
      if (rows != 0)
      {
        return rows;
      }

      var columns = board[0, i] & board[1, i] & board[2, i];
      if (columns != 0)
      {
        return columns;
      }
    }
    
    var diagonal = board[0, 0] & board[1, 1] & board[2, 2];
    if (diagonal != 0)
    {
      return diagonal;
    }

    var antiDiagonal = board[0, 2] & board[1, 1] & board[2, 0];
    if (antiDiagonal != 0)
    {
      return antiDiagonal;
    }

    return board.Cast<int>().Contains(0) ? -1 : 0;
  }
}