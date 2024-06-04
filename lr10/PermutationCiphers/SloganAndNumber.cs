using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    internal class SloganAndNumber
    {
        public SloganAndNumber() { }
        public SloganAndNumber(char symbol)
        {
            Symbol = symbol;
        }
        public SloganAndNumber(char symbol, int numberInWord) : this(symbol)
        {
            NumberInWord = numberInWord;
        }
        public SloganAndNumber(char symbol, int numberInWord, int numberInAlphabet) : this(symbol, numberInWord)
        {
            NumberInAlphabet = numberInAlphabet;
        }

        public char Symbol {  get; set; }
        public int NumberInWord { get; set; }
        public int NumberInAlphabet { get; set; }
    }
}
