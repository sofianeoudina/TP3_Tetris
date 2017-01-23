using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Piece : Grid
    {
        private int rows, columns;
        public char[,] blocks;
        public Piece(String s)
        {
            Char delimiter = '\n';
            String[] substrings = s.Split(delimiter);
            rows = substrings.Length - 1;
            columns = substrings[0].Length;
            blocks = new char[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    String tmp = substrings[i];
                    blocks[i, j] = tmp[j];
                }     
            }
        }
        public char CellAt(int row, int col)
        {
            return blocks[row, col];
        }

        public int Columns()
        {
            return columns;
        }

        public int Rows()
        {
            return rows;
        }

        public override string ToString()
        {
            String toReturn = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    toReturn += blocks[i, j];
                }
                toReturn += "\n";
            }
            return toReturn;
        }
    }
}
