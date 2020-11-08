using System.Linq;

namespace Adventofcode_2015
{
    class Day5b
    {
        public void main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day5.txt");
            string[] lines2 = { "qjhvhtzxzqqjkmpb", "xxyxx", "uurcxstgmygtbstg", "ieodomkazucvgmuy" };
            int nice = 0;
            foreach(string s in lines)
            {
                bool pair = false;
                bool between = false;
                char prev = ' ';
                char eerperv = ' ';
                string[] combos = new string[s.Length];
                foreach(char c in s)
                {
                    if (c == eerperv)
                    {
                        between = true;
                    }
                    for(int i = 0; i < combos.Length; i++)
                    {
                        if (combos[i] == null)
                        {
                            combos[i] = prev.ToString() + c.ToString();
                            break;
                        }
                        
                    }
                    eerperv = prev;
                    prev = c;
                }
                for (int i = 0; i < combos.Length - 1; i++)
                {
                    for (int j = i + 1; j < combos.Length; j++)
                    {
                        if (combos[i] == combos[j])
                        {
                            if (i + 1 != j)
                            {
                                pair = true;
                            }
                        }
                    }
                }

                if (pair&&between)
                {
                    nice++;
                }
            }
            System.Console.WriteLine(nice);
        }
    }
}