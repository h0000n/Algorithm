﻿using System.CodeDom.Compiler;
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
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}