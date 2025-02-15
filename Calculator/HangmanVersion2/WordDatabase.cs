using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanVersion2
{
    public class WordDatabase
    {
        protected string[] Words = new string[] { "Car", "Rocket", "Motorbike", "Skateboard" };
        protected Random randomGenerator = new Random();

        public string GetRandomWord()
        {
            return Words[randomGenerator.Next(0, Words.Length)];
        }
    }
}
