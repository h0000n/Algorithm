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
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;

class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int count = 0; //VPS(한쌍의 괄호)를 체크하기 위한 변수
            var stack = new Stack<char>(); //괄호를 담고있는 스택
            var input = Console.ReadLine(); //입력을 위한 변수
            for (int j = 0; j < input.Length; j++) //입력 받은 변수를 차례대로 스택에 Push
            {
                stack.Push(input[j]);
            }
            while (stack.Count > 0) //스택이 텅 비어있을때까지 반복
            {
                if (stack.Pop().Equals(')') && count > -1) //아직 VPS를 위반하지 않은 스택에서 Pop하여 괄호가 닫힌 상태인지 판별
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            if (count == 0) //VPS를 위반하지 않은 상태 체크
                sb.AppendLine("YES");
            else
                sb.AppendLine("NO");
        }
        Console.WriteLine(sb);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
