using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Block
    {
        public char letter;

        public Block(char letter)
        {
            this.letter = letter;
        }

        public char getLetter()
        {
            return letter;
        }

        public override string ToString()
        {
            return letter.ToString();
        }
    }
}
