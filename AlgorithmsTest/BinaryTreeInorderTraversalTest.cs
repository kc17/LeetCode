using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeInorderTraversalTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode root, IList<int> output)
        {
            Assert.Equal(output, Solution094.InorderTraversal(root));
        }
    }
}

