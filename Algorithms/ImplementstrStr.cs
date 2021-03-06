// Source : https://leetcode.com/problems/implement-strstr/ 
// Author : codeyu 
// Date : Thursday, October 13, 2016 11:07:52 PM 

/**********************************************************************************
*
* 
* Implement strStr().
* 
* 
* Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution028 
    {
        public static int StrStr(string haystack, string needle) 
        {
            int i,j;
            for(i=j=0;i<haystack.Length&&j<needle.Length;)
            {
                if(haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i -= j -1;
                    j = 0;
                }
            }
            return j != needle.Length ? -1 : i - j;  
        }
    }
}

