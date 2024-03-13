using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLeetCode
{
    internal class RomanToIntegerProblem
    {
        public int RomanToInt(string s)
        {
            int number = 0;
            char c = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M':
                       number = number + 1000;
                        break;
                    case 'D':
                        number = number + 500;
                        break;
                    case 'C':
                        number = number + 100;
                        break;
                    case 'L':
                        number = number + 50;
                        break;
                    case 'X':
                        number = number + 10;
                        break;
                    case 'V':
                        number = number + 5;
                        break;
                    case 'I':
                        number = number + 1;
                        break;
                }
            }
            if (s.Contains("IV")|| s.Contains("IX"))
                number -= 2;

            if (s.Contains("XL")|| s.Contains("XC"))
                number -= 20;

            if (s.Contains("CD")|| s.Contains("CM"))
                number -= 200;

            return number;

        }
    }
}
