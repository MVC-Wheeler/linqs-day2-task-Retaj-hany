using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EngMai
{
    public static class Exetention
    {
        public static int CoubtWords(this string s)
        {
            int count = 1;
            foreach (char c in s)
            {
                if(c ==  ' ') count++;
            }
            return count;
        }
    }
}
