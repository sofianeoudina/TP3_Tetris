using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Board
    {
        readonly int rows;
        readonly int columns;
        public Block[,] board;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

            init();
        }

        private void init()
        {
            board = new Block[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    board[row, col] = new Block('.');
                }
            }
        }

        public override String ToString()
        {
            String s = "";
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    s += board[row, col];
                }
                s += "\n";
            }
            return s;
        }

        public bool IsFallingBlock()
        {
            bool toReturn = false;
            for (int i = 0; i < columns; i++)
            {
                if (board[0, i].getLetter() != '.') toReturn = true;
            }
            return toReturn;
        }

        public void Drop(Block newBlock)
        {
            int center = columns / 2;
            board[0, center] = newBlock;
        }

        public void Tick()
        {
            for (int row = rows - 2; row >= 0; row--)
            {
                for (int col = 0; col < columns; col++)
                {
                    if(board[row, col].getLetter() != '.' && board[row + 1, col].getLetter() == '.'){
                        Block tmp = board[row, col];
                        board[row, col] = board[row + 1, col];
                        board[row + 1, col] = tmp;
                    }
                }
            }
        }
    }
}
