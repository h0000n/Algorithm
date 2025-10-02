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
        //이항 계수 https://namu.wiki/w/%EC%9D%B4%ED%95%AD%EC%A0%95%EB%A6%AC 참조
        StringBuilder sb = new StringBuilder();
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int result = 0;
        int N = input[0];
        int K = input[1];
        result = Factorial(N) / (Factorial(K) * Factorial(N - K)); //이항 계수를 구하는 공식대로 팩토리얼 함수를 사용해 이항 계수를 구함
        sb.Append(result);
        Console.WriteLine(sb);
    }

    public static int Factorial(int num) //입력된 값의 팩토리얼 값을 반환
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = result * i;
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
