using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Tetromino
    {
        public String[] rotations;
        public int index_rotatation;
        public Tetromino(String r1, String r2, String r3, String r4)
        {
            rotations = new String[4] { r1, r2, r3, r4};
            index_rotatation = 0;
        }
        public override string ToString()
        {
            return rotations[index_rotatation];
        }

        public Tetromino(Tetromino t)
        {
            rotations = new String[4];
            for (int i = 0; i < 4; i++)
                rotations[i] = t.rotations[i];
            index_rotatation = t.index_rotatation;
                
        }

        public Tetromino RotateRight()
        {
            Tetromino newTetromino = new Tetromino(this);
            newTetromino.index_rotatation++;
            if (newTetromino.index_rotatation == 4) newTetromino.index_rotatation = 0;
            
            return newTetromino;
        }

        public Tetromino RotateLeft()
        {
            Tetromino newTetromino = new Tetromino(this);
            newTetromino.index_rotatation--;
            if (newTetromino.index_rotatation < 0) newTetromino.index_rotatation = 3;

            return newTetromino;
        }
    }
}
