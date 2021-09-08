using System;
using System.Collections.Generic;

namespace Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>()
            {
               "Different",
               "Goodbye",
               "Greetings",

            };

            var wordbank = new WordBank();

            var word = wordbank.GetWord();
        }
    }
}
