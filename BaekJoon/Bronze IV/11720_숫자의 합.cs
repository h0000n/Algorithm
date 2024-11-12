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
        int N = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += int.Parse(input[i].ToString());
        }
        sb.AppendLine(sum.ToString());
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