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
        int[] inputN = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        Array.Sort(inputN);
        int M = int.Parse(Console.ReadLine());
        int[] count = new int[M];
        int[] inputM = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        for (int i = 0; i < M; i++)
        {
            while (BinarySearch(inputN, inputM[i]) != -1)
            {
                inputN[BinarySearch(inputN, inputM[i])] = 0;
                Array.Sort(inputN);
                count[i]++;
            }
        }
        foreach (int a in count)
        {
            sb.Append(a + " ");
        }
        Console.WriteLine(sb);
    }

    public static int BinarySearch(int[] arr, int value)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == value)
            {
                return mid;
            }
            else if (arr[mid] < value)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
