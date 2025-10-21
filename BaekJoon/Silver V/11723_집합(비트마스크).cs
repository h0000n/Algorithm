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
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;

class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        string[] input;
        int S = 0;
        int M = int.Parse(Console.ReadLine());
        for (int i = 0; i < M; i++)
        {
            input = Console.ReadLine()!.Split(" ").ToArray();
            switch (input[0]) //입력받은 구문을 비교하여 명령 수행
            {
                case "add":
                    // 해당 원소를 집합에 추가 (비트 켜기)
                    S |= (1 << int.Parse(input[1]));
                    break;

                case "remove":
                    // 해당 원소를 집합에서 제거 (비트 끄기)
                    S &= ~(1 << int.Parse(input[1]));
                    break;

                case "check":
                    // 해당 원소가 집합에 있는지 확인 (비트가 켜져 있으면 1, 아니면 0 출력)
                    if ((S & (1 << int.Parse(input[1]))) != 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                    break;

                case "toggle":
                    // 해당 원소의 포함 여부를 반전 (비트 XOR로 뒤집기)
                    S ^= (1 << int.Parse(input[1]));
                    break;

                case "all":
                    // 1부터 20까지 모든 원소를 집합에 추가 (모든 비트를 켬)
                    S = (1 << 21) - 1;
                    break;

                case "empty":
                    // 집합을 공집합으로 초기화 (모든 비트 끄기)
                    S = 0;
                    break;
            }
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
