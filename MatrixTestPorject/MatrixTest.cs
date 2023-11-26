using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixProject;
using System.Collections.Generic;

namespace MatrixTestPorject
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void ProductOfNegativeElements__RandomList_ReturnedCorrectResult()
        {
            List<List<int>> list = new List<List<int>>() { new List<int>() { 1, -2, 10 }, new List<int>() { 5, -4, 2 }, new List<int>() { 8, -10, 6 } };

            Matrix matrix = new Matrix(list);

            int expectedResult = -80;
            int actualResult = matrix.CalculateProductOfNegativeElements();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProductOfNegativeElementsInEvenRows_RandomList_ReturnedCorrectResult()
        {
            List<List<int>> list = new List<List<int>>() { new List<int>() { 1, -2, 10 }, new List<int>() { 5, -4, 2 }, new List<int>() { 8, -10, 6 } };

            Matrix matrix = new Matrix(list);

            int expectedResult = -10;
            int actualResult = matrix.CalculateProductOfNegativeElementsInEvenRows();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
