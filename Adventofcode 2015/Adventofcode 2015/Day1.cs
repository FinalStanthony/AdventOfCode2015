using System;

namespace Adventofcode_2015
{
    class Day1
    {
        public void main()
        {
            string lines = System.IO.File.ReadAllText(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day1.txt");
            int res = 0;
            foreach (char c in lines)
            {
                if (c == '(')
                {
                    res++;
                }
                else if (c == ')')
                {
                    res--;
                }
            }
            System.Console.WriteLine(res);

        }
    }
}
