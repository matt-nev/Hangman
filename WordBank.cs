using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class WordBank
    {
        private List<string> words;
        public WordBank()
        {
            words = new List<string>()
            {
               "Hello",
               "Goodbye",
               "Greetings",

            };

            // same as above, different syntax
                // words = new List<string>();
                // words.Add("Hello");
                // words.Add("Goodbye");

        }
        public WordBank(List<string> words)
        {
            this.words = words;
        }

        public string GetWord()
        {
            var random = new Random();
            var index = random.Next(0, words.Count - 1);

            return words[index];
        }
    }
}
