using AreTheyTheSame.App;
using Xunit;

namespace AreTheyTheSame.Test
{
    public class CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArrayTest
    {
        [Fact]
        public void compTest1_Successful()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.True(actual);

        }
        
        [Fact]
        public void compTest2_Successful()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.True(actual);

        }

        [Fact]
        public void compTest3_Successful()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.True(actual);

        }

        [Fact]
        public void compTest1_ShouldReturnNull_ArrayAIsNull()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = null;
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);

        } 
        
        [Fact]
        public void compTest2_ShouldReturnNull_ArrayAIsNull()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] {};
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);

        }

        [Fact]
        public void compTest3_ShouldReturnNull_ArrayBIsNull()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            int[] b = null;

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void compTest4_ShouldReturnFalse_NotTheSame()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void compTest5_ShouldReturnFalse_ArraysAreNotTheSameLength()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19};
            int[] b = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void compTest6_ShouldReturnFalse()
        {
            //Arrange
            ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray caluclateIfTwoArraysAreEqual = new CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray();

            int[] a = new int[] { 2, 2, 3 };
            int[] b = new int[] { 4, 9, 9 };

            //Act

            var actual = caluclateIfTwoArraysAreEqual.comp(a, b);

            //Assert
            Assert.False(actual);
        }
    }
}
