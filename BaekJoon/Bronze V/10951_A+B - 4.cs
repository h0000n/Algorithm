using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == null)
                break;
            string[] spl = input.Split(' ');
            int sum = int.Parse(spl[0]) + int.Parse(spl[1]);
            sb.AppendLine(sum.ToString());
        }
        Console.Write(sb);
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}