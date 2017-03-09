using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ReverseLinkedListIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(ListNode head, int m, int n, ListNode output)
        {
            Assert.Equal(output, Solution092.ReverseBetween(head, m, n));
        }
    }
}

