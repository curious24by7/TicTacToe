using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] array = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public void ChoosePlayer()
        {
            
        }
        public void ChooseSymbol()
        {
            Console.WriteLine("Press 1 to use 'X' or Press 2 to use 'O'. ");
            var ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    Console.WriteLine("You have choosed 'X'");
                    Console.WriteLine("P1=X");
                    break;
                case "2":
                    Console.WriteLine("You have choosed 'O'");
                    Console.WriteLine("P1=0");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            if (ans == "1")
            {
                Console.WriteLine("Computer is using O");
            }
            else
            {
                Console.WriteLine("Computer is using X");
            }
           
        }

        public void GameBoard()
        {
            Console.WriteLine("|" + array[0] + "|" + array[1] + "|" + array[2] + "|");
            Console.WriteLine("---------------------");
            Console.WriteLine("|" + array[3] + "|" + array[4] + "|" + array[5] + "|");
            Console.WriteLine("----------------------");
            Console.WriteLine("|" + array[6] + "|" + array[7] + "|" + array[8] + "|");

        }

    }
}
