using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Game
    {
        private string answer;

        private List<char> guesses = new List<char>();

        private int lives;

        public Game(int lives, string answer)
        {
            this.answer = answer;
            this.lives = lives;
        }

        public int GetLives()
        {
            return lives;
        }

        public void LoseLife()
        {
            lives--;
        }

        public bool CheckIfNoLives()
        {
            return lives < 1;
        }

        public int GetAnswerLength()
        {
            return answer.Length;
        }

        public void AddGuess(char guess)
        {
            guesses.Add(guess);
        }

        public string GetGuesses()
        {
            var builder = new StringBuilder();

            foreach (var let in guesses)
            {
                builder.Append($"{let} ");
            }

            return builder.ToString().Trim();
        }

        public string GetAnswerStringToDisplayToUsers()
        {
            var builder = new StringBuilder();

            foreach (var let in answer)
            {
                if (guesses.Contains(let))
                {
                    builder.Append($"{ let } ");
                }
                else
                {
                    builder.Append("_ ");
                }
            }

            return builder.ToString().Trim();
        }

        public bool IsLetterInAnswer(char letter)
        {
            return answer.Contains(letter);
        }

        public bool HasLetterBeenGuessed(char letter)
        {
            return guesses.Contains(letter);
        }

        public bool CheckIfPlayerWon()
        {

            if (CheckIfNoLives()) return false;

            foreach (var let in answer)
            {
                if (!guesses.Contains(let)) return false;
            }

            return true;
        }
    }

}
