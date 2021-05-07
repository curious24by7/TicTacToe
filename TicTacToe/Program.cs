using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe");
            var tictactoegame = new TicTacToeGame();
            //tictactoegame.ChooseSymbol();
            tictactoegame.GameBoard();
            tictactoegame.GamePlay();
        }
    }
}
