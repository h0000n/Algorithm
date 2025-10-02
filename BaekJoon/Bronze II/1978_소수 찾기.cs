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
        int N = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int result = 0;
        bool prime; //소수 판별을 위한 bool 자료형 선언
        for (int i = 0; i < N; i++)
        {
            prime = true;
            if (input[i] == 1) //1은 소수가 아님
            {
                prime = false;
            }
            for (int j = 2; j*j <= input[i]; j++) //2부터 판별할 수의 제곱근까지만 나누어도 판별이 가능하다
                {
                    if (input[i] % j == 0)
                    {
                        prime = false;
                    }
                }
            if (prime)
            {
                result++;
            }
        }
        Console.Write(result);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
