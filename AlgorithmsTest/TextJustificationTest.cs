using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class TextJustificationTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string[] words, int maxWidth, IList<string> output)
        {
            Assert.Equal(output, Solution068.FullJustify(words, maxWidth));
        }
    }
}

