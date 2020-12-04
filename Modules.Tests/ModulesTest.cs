﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modules.Tests
{
    [TestClass]
    public class ModulesTest
    {
        [TestMethod]
        public void IsArrayReverseArrayGenerated()
        {
            var actual = GenerateReverseArray.ReverseSeq(5);

            var expected = new int[] { 5, 4, 3, 2, 1 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CheckMultiplicationTable()
        {
            var actual = MultiplicationTable.GenerateTable(3);
            var expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}