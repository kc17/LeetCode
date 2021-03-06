using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MinimumPathSumTest
    {
        [Theory]
        [MemberDataAttribute("InlineData")]
        public void TestMethod(int[,] grid, int output)
        {
            Assert.Equal(output, Solution064.MinPathSum(grid));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[,] obstacleGrid = new int[,] { 
                    { 0,0,0 }, 
                    { 0,1,0}, 
                    { 0,0,0 }
                };
                int output = 0;
                driverData.Add(new object[] { obstacleGrid,output });
                obstacleGrid = new int[,] { 
                    { 0,1 },
                };
                output = 1;
                driverData.Add(new object[] { obstacleGrid,output });
                return driverData;
            }
        }   
    }
}

