using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class AddBinaryTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string a, string b, string output)
        {
            Assert.Equal(output, Solution067.AddBinary(a, b));
        }
    }
}

