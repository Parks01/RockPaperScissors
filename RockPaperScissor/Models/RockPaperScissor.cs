using System;
using System.Collections.Generic;

namespace RockPaperScissor.Models
{
    public class RockPaper
    {
        //Private fields
        private string _player1Input;
        private string _player2Input;

        //Constructor
        public RockPaper (string player1Input1, string playerInput2)
        {
            _player1Input = player1Input1;
            _player2Input = playerInput2;
        }

        //Methods
        public string Play()
        {
          string result = "";
          if (_player1Input == "scissors" && _player2Input == "paper")
          {
            result = "player1";
          }
          else if(_player1Input == _player2Input)
          {
            result = "draw";
          }
          else if(_player1Input == "scissors" && _player2Input == "rock")
          {
            result = "player2";
          }
          else if(_player1Input == "rock" && _player2Input == "paper")
          {
            result = "player2";
          }
          return result;
        }
    }
}
