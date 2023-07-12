using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz
{
    class FrequencyCounter
    {
        private Dictionary<char, int> characterFrequencies;
        public FrequencyCounter(string input)
        {
            characterFrequencies = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if (characterFrequencies.ContainsKey(ch))
                {
                    characterFrequencies[ch]++;
                }
                else
                {
                    characterFrequencies[ch] = 1;
                }
            }
        }
        public int this[char character]
        {
            get
            {
                return characterFrequencies.ContainsKey(character) ? characterFrequencies[character] : 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencyCounter counter = new FrequencyCounter("hello world");
            Console.WriteLine(counter['l']);
        }
    }
}
