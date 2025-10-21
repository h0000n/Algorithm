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

class Result
{
    public static int M;
    public static int N;
    public static string[,] board;
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        M = input[0];
        N = input[1];
        string boardInput;
        board = new string[M, N];
        int count = 64;
        for (int i = 0; i < M; i++)
        {
            boardInput = Console.ReadLine();
            for (int j = 0; j < N; j++)
            {
                board[i, j] = boardInput[j].ToString(); //입력받은 체스판의 색깔을 하나하나 잘라서 2차원 int 배열에 초기화
            }
        }
        for (int y = 0; y <= M - 8; y++) //주어진 체스판에서 8x8칸으로 자름
        {
            for (int x = 0; x <= N - 8; x++)
            {
                count = Math.Min(count, Check(y, x)); //자른 체스판의 시작 점을 Check함수로 넘겨서 가장 고칠곳이 적은 체스판의 틀린 개수를 count에 초기화
            }
        }
        sb.Append(count);
        Console.WriteLine(sb);
    }

    public static int Check(int startY, int startX) //체스판의 틀린 부분을 찾기 위한 함수 틀린 개수를 반환
    {
        (int a, int b) count = (0, 0); //체스판의 첫 칸이 무슨색인지에 따라 두가지의 케이스 체크를 위해서 int 튜플 선언 count에 a,b 두개의 int값을 갖고있음 
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                if ((y + x) % 2 == 0) //체스판 홀수줄, 짝수줄 구분하여 두가지 케이스에 따라 틀린 부분 체크
                {
                    if (board[startY + y, startX + x] != "W")
                        count.a++;
                    if (board[startY + y, startX + x] != "B")
                        count.b++;
                }
                else
                {
                    if (board[startY + y, startX + x] != "B")
                        count.a++;
                    if (board[startY + y, startX + x] != "W")
                        count.b++;
                }
            }
        }
        return Math.Min(count.a, count.b); //두가지 케이스 중 틀린곳이 더 적은 체스판을 골라 고쳐야 하는수를 반환
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
