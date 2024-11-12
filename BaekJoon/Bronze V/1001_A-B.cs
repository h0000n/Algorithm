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
    public static int Sol()
    {
        int result = 0;
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        result = input[0] - input[1];
        return result;
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        Console.Write(Result.Sol());
    }
}
