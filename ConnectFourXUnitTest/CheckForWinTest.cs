using ConnectFour;
using Xunit;

namespace ConnectFourXUnitTest
{
	public class CheckForWinTest
	{
		private GameState gameState;

		public enum TestWinState
		{
			No_Winner = 0,
			Player1_Wins = 1,
			Player2_Wins = 2,
			Tie = 3
		}

		public CheckForWinTest()
		{
			gameState = new GameState();
		}

		[Fact]
		public void CheckForWin_NoWinner_EmptyBoard()
		{
			gameState.SetBoard(new List<int>(42));

			var result = gameState.CheckForWin();

			Assert.Equal(GameState.WinState.No_Winner, (GameState.WinState)result);
		}

		[Fact]
		public void CheckForWin_TieGame()
		{
			gameState.SetBoard(new List<int>
			{
				1, 2, 1, 2, 1, 2, 1,
				1, 1, 2, 1, 2, 1, 2,
				2, 2, 2, 1, 2, 2, 1,
				2, 1, 2, 1, 2, 1, 2,
				1, 2, 1, 2, 1, 1, 2,
				2, 1, 2, 1, 2, 1, 2
			});

			var result = gameState.CheckForWin();

			Assert.Equal(GameState.WinState.Tie, (GameState.WinState)result);
		}
	}
}
