using System.Linq;

namespace Adventofcode_2015
{
    class Day5
    {
        public void main()
        {
            char[] vowels = { 'a', 'e', 'u', 'i', 'o' };
            char[] substrings ={'a', 'c', 'p', 'x'};
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day5.txt");
            int nice = 0;
            foreach(string s in lines)
            {
                bool substring = false;
                bool dubbel = false;
                bool b = true;
                int count = 0;
                char prev = ' ';
                foreach(char c in s)
                {
                    if (vowels.Contains(c)){
                        count++;
                    }
                    if(!dubbel&&c == prev)
                    {
                        dubbel = true;
                    }
                    if (substring)
                    {
                        if ((int)prev == (int)c - 1)
                        {
                            b = false;
                            break;
                        }
                        substring = false;
                    }
                    if (substrings.Contains(c))
                    {
                        substring = true;
                    }
                    prev = c;
                }
                if (count >= 3 && dubbel && b)
                {
                    nice++;
                }
            }
            System.Console.WriteLine(nice);
        }
    }
}