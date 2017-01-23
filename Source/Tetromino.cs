using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Tetromino : Grid
    {
        public readonly Piece[] rotations;
        public int index_rotation;
        public int length;

        public Tetromino(String r1, String r2, String r3, String r4)
        {
            rotations = new Piece[4] { new Piece(r1), new Piece(r2), new Piece(r3), new Piece(r4) };
            length = 4;
            index_rotation = 0;
        }
        public Tetromino(String r1, String r2)
        {
            rotations = new Piece[2] { new Piece(r1), new Piece(r2) };
            index_rotation = 0;
            length = 2;
        }
        public Tetromino(String r1)
        {
            rotations = new Piece[1] { new Piece(r1) };
            index_rotation = 0;
            length = 1;
        }

        public override string ToString()
        {
            return rotations[index_rotation].ToString();
        }

        public Tetromino(Tetromino t)
        {
            rotations = new Piece[t.length];
            for (int i = 0; i < t.length; i++)
                rotations[i] = t.rotations[i];
            index_rotation = t.index_rotation;
            length = t.length;
                
        }

        public Tetromino RotateRight()
        {
            Tetromino newTetromino = new Tetromino(this);
            newTetromino.index_rotation++;
            if (newTetromino.index_rotation == length) newTetromino.index_rotation = 0;
            
            return newTetromino;
        }

        public Tetromino RotateLeft()
        {
            Tetromino newTetromino = new Tetromino(this);
            newTetromino.index_rotation--;
            if (newTetromino.index_rotation < 0) newTetromino.index_rotation = length - 1;

            return newTetromino;
        }

        public int Rows()
        {
            return rotations[index_rotation].Rows();
        }

        public int Columns()
        {
            return rotations[index_rotation].Columns();
        }

        public char CellAt(int row, int col)
        {
            return rotations[index_rotation].CellAt(row, col);
        }

        public static Tetromino T_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                "TTT.\n" +
                ".T..\n"
                ,
                ".T..\n" +
                "TT..\n" +
                ".T..\n"
                ,
                "....\n" +
                ".T..\n" +
                "TTT.\n"
                ,
                ".T..\n" +
                ".TT.\n" +
                ".T..\n"
                );
            }
        }

        public static Tetromino I_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                "IIII\n" +
                "....\n" +
                "....\n"
                ,
                "..I.\n" +
                "..I.\n" +
                "..I.\n" +
                "..I.\n"
                );
            }
        }

        public static Tetromino L_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                "LLL.\n" +
                "L...\n"
                ,
                "LL..\n" +
                ".L..\n" +
                ".L..\n"
                ,
                "....\n" +
                "..L.\n" +
                "LLL.\n"
                ,
                ".L..\n" +
                ".L..\n" +
                ".LL.\n"
                );
            }
        }

        public static Tetromino J_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                "JJJ.\n" +
                "..J.\n"
                ,
                ".J..\n" +
                ".J..\n" +
                "JJ..\n"
                ,
                "....\n" +
                "J...\n" +
                "JJJ.\n"
                ,
                ".JJ.\n" +
                ".J..\n" +
                ".J..\n"
                );
            }
        }

        public static Tetromino S_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                ".SS.\n" +
                "SS..\n"
                ,
                "S...\n" +
                "SS..\n" +
                ".S..\n"
                );
            }
        }

        public static Tetromino Z_SHAPE
        {
            get
            {
                return new Tetromino(
                "....\n" +
                "ZZ..\n" +
                ".ZZ.\n"
                ,
                "..Z.\n" +
                ".ZZ.\n" +
                ".Z..\n"
                );
            }
        }

        public static Tetromino O_SHAPE
        {
            get
            {
                return new Tetromino(
                ".OO.\n" +
                ".OO.\n"
                );
            }
        }
    }
}
