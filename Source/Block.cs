using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class MovableGrid : Grid
    {
        public char letter;
        public bool isFalling;

        public MovableGrid(char letter)
        {
            this.letter = letter;
            isFalling = true;
        }

        public MovableGrid(Grid shape)
        {
            this.letter = shape.CellAt(0, 0);
            isFalling = true;
        }

        public char getLetter()
        {
            return letter;
        }

        public override string ToString()
        {
            return letter.ToString();
        }

        public int Rows()
        {
            return 1;
        }

        public int Columns()
        {
            return 1;
        }

        public char CellAt(int row, int col)
        {
            return letter;
        }
    }
}
