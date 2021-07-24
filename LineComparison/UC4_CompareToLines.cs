using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC4_CompareToLines
    {
        public void compareTwoLine(String a, String b)
        {
            double c;
            c = a.CompareTo(b);

            if (c == 0)
            {
                Console.WriteLine("The lengths of two line is equal");
            }
            else if (c > 0)
            {
                Console.WriteLine("Length of first line is greater than length of second line");
            }
            else
            {
                Console.WriteLine("Length of first line is less than length of second line");
            }
        }

    }
}
