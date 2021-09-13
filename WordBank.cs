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
                "greetings",
                "goodbye",
                "hello",
                "arrangement",
                "attempt",
                "brick",
                "discussion",
                "essential",
                "exchange",
                "explanation",
                "fireplace",
                "floating",
                "garage",
                "grandmother",
                "grandfather",
                "heading",
                "independent",
                "instant",
                "manufacturing",
                "mathematics",
                "memory",
                "mysterious",
                "neighborhood",
                "occasionally",
                "official",
                "positive",
                "possibly",
                "practical",
                "remarkable",
                "satisfied",
                "selection",
                "simplest",
                "species",
                "thumb",
                "tobacco",
                "vessels",
            };
        }

        public string GetWord()
        {
            var random = new Random();
            var index = random.Next(words.Count);

            return words[index];
        }
    }
}


