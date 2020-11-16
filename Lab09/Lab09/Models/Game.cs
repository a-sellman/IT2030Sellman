﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab09.Models
{
    public class Game
    {
        public const int WinningNumber = 20;
        private Random rand = new Random();

        public Game()
        {
            NewGame();
        }

        public string CurrentPlayerName { get; set; }
        public int CurrentTurnScore { get; set; }
        public bool IsGameOver { get; set; }
        public int LastRoll { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public void ChangePlayer()
        {
            CurrentPlayerName = (CurrentPlayerName == Player1.Name) ? Player2.Name : Player1.Name;
        }

        public void Hold()
        {
            Player current = (CurrentPlayerName == Player1.Name) ? Player1 : Player2;
            current.Score += CurrentTurnScore;
            if (current.Score >= WinningNumber)
            {
                IsGameOver = true;
            }
            else
            {
                CurrentTurnScore = 0;
                LastRoll = 0;
                ChangePlayer();
            }
        }

        public void NewGame()
        {
            Player1 = new Player { Name = "Player 1" };
            Player2 = new Player { Name = "Player 2" };
            CurrentPlayerName = Player1.Name;
            CurrentTurnScore = 0;
            LastRoll = 0;
            IsGameOver = false;
        }

        public void Roll()
        {
            LastRoll = rand.Next(1, 7);
            if (LastRoll == 1)
            {
                CurrentTurnScore = 0;
                ChangePlayer();
            }
            else
            {
                CurrentTurnScore += LastRoll;
            }
        }
    }
}