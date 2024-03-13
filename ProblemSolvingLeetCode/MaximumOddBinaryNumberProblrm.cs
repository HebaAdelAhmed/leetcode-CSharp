using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLeetCode
{
    internal class MaximumOddBinaryNumberProblrm
    {
        public string MaximumOddBinaryNumber(string s)
        {
            int LengthOfString = s.Length;
            int NumberOfOnes = 0;
            for (int i = 0; i < LengthOfString; i++)
            {
                if (s[i] == '1')
                    NumberOfOnes++;
            }
            StringBuilder builder = new StringBuilder();
            if(NumberOfOnes > 1)
                for (int i = 0;i < NumberOfOnes -1; i++)
                {
                    builder.Append('1');
                }
            int NumberOfZeros = LengthOfString - NumberOfOnes;
            for (int i = 0; i < NumberOfZeros; i++)
                builder.Append('0');
            builder.Append('1');
            return builder.ToString();
        }
    }
}
