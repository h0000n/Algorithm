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
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine((input[0] + input[1]).ToString());
        sb.AppendLine((input[0] - input[1]).ToString());
        sb.AppendLine((input[0] * input[1]).ToString());
        sb.AppendLine((input[0] / input[1]).ToString());
        sb.AppendLine((input[0] % input[1]).ToString());

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