using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class UniqueBinarySearchTreesTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution096.NumTrees(n));
        }
    }
}

