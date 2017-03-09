using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class UniqueBinarySearchTreesIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, IList<TreeNode> output)
        {
            Assert.Equal(output, Solution095.GenerateTrees(n));
        }
    }
}

