using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Source;

namespace Test
{
    [TestClass]
    public class Step2_TetrominoesTest
    {

        #region T_SHAPE

        static Tetromino T_SHAPE = Tetromino.T_SHAPE;
        Tetromino shape_right = T_SHAPE.RotateRight();
        Tetromino shape_left = T_SHAPE.RotateLeft();
        Tetromino shape = T_SHAPE;

        [TestMethod]
        public void T_shape_first_orientation()
        {
            // assert
            Assert.AreEqual(T_SHAPE.ToString(),
                "....\n" +
                "TTT.\n" +
                ".T..\n"
            );
        }

        [TestMethod]
        public void T_shape_rotated_right()
        {
            // assert
            Assert.AreEqual(shape_right.ToString(),
                ".T..\n" +
                "TT..\n" +
                ".T..\n"
            );
        }

        [TestMethod]
        public void T_shape_rotated_left()
        {
            // assert
            Assert.AreEqual(shape_left.ToString(),
                ".T..\n" +
                ".TT.\n" +
                ".T..\n"
            );
        }

        [TestMethod]
        public void T_shape_looped_around_right()
        {
            shape = shape.RotateRight();
            shape = shape.RotateRight();
            shape = shape.RotateRight();
            shape = shape.RotateRight();

            // assert
            Assert.AreEqual(shape.ToString(), T_SHAPE.ToString());
        }

        [TestMethod]
        public void T_shape_looped_around_left()
        {
            shape = shape.RotateLeft();
            shape = shape.RotateLeft();
            shape = shape.RotateLeft();
            shape = shape.RotateLeft();

            // assert
            Assert.AreEqual(shape.ToString(), T_SHAPE.ToString());
        }

        #endregion

        #region immutable

        [TestMethod]
        public void tetrominoes_are_immutable()
        {
            String original = T_SHAPE.ToString();

            // act
            T_SHAPE.RotateRight();

            // assert
            Assert.AreEqual(original, T_SHAPE.ToString());

            // act
            T_SHAPE.RotateLeft();

            // assert
            Assert.AreEqual(original, T_SHAPE.ToString());
        }

        #endregion
    }
}
