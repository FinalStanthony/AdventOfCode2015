using System;
using System.Collections.Generic;
using System.IO;

namespace Adventofcode_2015
{
    class Day7
    {
        Dictionary<string, string> book = new Dictionary<string, string>();
        Dictionary<string, ushort> number = new Dictionary<string, ushort>();
        public void main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day7.txt");
            foreach (String line in lines)
            {
                string[] split = line.Split(" -> ");
                book.Add(split[1], split[0]);

            }
            string input = "a";
            string input2 = "16076";
            book["b"] = input2;
            System.Console.WriteLine(recur(input));

        }

        public ushort recur(string input) {
            string output;
            ushort n;
            if (number.TryGetValue(input, out n))
            {
                return Convert.ToUInt16(n);
            }
            if (book.TryGetValue(input, out output)){
                Console.WriteLine(input + "= " + output);
                string[] split = output.Split(" ");
                if (split.Length == 1)
                {
                    try
                    {
                        number.Add(input, Convert.ToUInt16(output));
                        return (Convert.ToUInt16(output));
                    }
                    catch
                    {
                        return recur(output);
                    }
                }
                else if (split.Length == 2)
                {
                    ushort temp = recur(split[1]);
                    return Convert.ToUInt16(UInt16.MaxValue - temp);
                }
                else
                {
                    ushort temp;
                    switch (split[1])
                    {
                        case "AND":
                            if (split[0] == "1")
                            {
                                temp = Convert.ToUInt16(Convert.ToUInt16((Convert.ToUInt16(1) & recur(split[2]))));
                                number.Add(input, temp);
                                return temp;
                            }
                            if (split[2] == "1")
                            {
                                temp = Convert.ToUInt16(Convert.ToUInt16((Convert.ToUInt16(1) & recur(split[0]))));
                                number.Add(input, temp);
                                return temp;
                            }
                            temp = Convert.ToUInt16(Convert.ToUInt16(recur(split[0]) & recur(split[2])));
                            number.Add(input, temp);
                            return temp;
                        case "OR":
                            temp = Convert.ToUInt16(recur(split[0]) | recur(split[2]));
                            number.Add(input, temp);
                            return temp;
                        case "RSHIFT":
                            temp = Convert.ToUInt16(recur(split[0]) >> Convert.ToUInt16(split[2]));
                            number.Add(input, temp);
                            return temp;
                        case "LSHIFT":
                            temp = Convert.ToUInt16(recur(split[0]) << Convert.ToUInt16(split[2]));
                            number.Add(input, temp);
                            return temp;
                    }
                    return 0;
                }

            }
            else
            {
                return Convert.ToUInt16(input);
            }
        }

    }
}
