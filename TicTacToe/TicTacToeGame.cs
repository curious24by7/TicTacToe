﻿using System;
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
        public void GameBoard()
        {
            Console.WriteLine("|"+"|"+ "|"+ "|");
            Console.WriteLine("----------------------");
            Console.WriteLine("|" + "|" + "|" + "|");
            Console.WriteLine("----------------------");
            Console.WriteLine("|" + "|" + "|" + "|");
        }
    }
}