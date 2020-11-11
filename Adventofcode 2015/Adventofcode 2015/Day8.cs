using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Adventofcode_2015
{
    class Day8
    {
        public void main()
        {
            int total = 0;
            int memory = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day8.txt");
            foreach(string s in lines)
            {
                total += s.Length;
                string mem = s.Substring(1, s.Length - 2);
                mem = mem.Replace("\\\"", "\"");
                mem = mem.Replace("\\\\", "?");
                string pattern = @"\\x[0-9a-f]{2}";
                mem = Regex.Replace(mem, pattern, "?");
                memory += mem.Length;
            }
            System.Console.WriteLine(total - memory);
        }
    }
}
