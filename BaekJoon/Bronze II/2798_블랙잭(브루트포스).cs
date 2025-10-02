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
        int[] NM = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int N = NM[0];
        int M = NM[1];
        int result = 0;

        for (int i = 0; i < N - 2; i++) //3개를 고르기 때문에 첫번째 카드는 N - 2 까지 순회
        {
            if (input[i] > M) continue; //입력된 값이 블랙잭이 되는 숫자인 M을 초과할 경우 스킵
            for (int j = i + 1; j < N - 1; j++) //두 번째 카드는 첫 번째 카드 다음부터 N - 1 까지 순회
            {
                if (input[i] + input[j] > M) continue; //첫번째 카드와 두번째 카드의 합이 블랙잭이 되는 숫자인 M을 초과할 경우 스킵

                for (int k = j + 1; k < N; k++) //세 번째 카드는 두 번째 카드 다음부터 N 까지 순회
                {
                    int sum = input[i] + input[j] + input[k]; //세 카드의 합이 M을 초과할 경우 스킵
                    if (M == sum) // 세 카드의 합이 블랙잭 즉 M일 경우 result를 합으로 초기화하고 탈출
                    {
                        result = sum;
                        break;
                    }

                    if (result < sum && sum < M) //세 카드의 합이 기존의 값보다 크고 블랙잭보다 작은 수일 경우 값을 교체
                    {
                        result = sum;
                    }
                }
            }
        }
        sb.Append(result);
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
