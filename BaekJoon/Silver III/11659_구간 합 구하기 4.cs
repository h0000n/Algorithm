using System.Text;

namespace sol
{
    class Program
    {
        static void Main(string[] args)
        {
            _Sol();
        }

        static void _Sol()
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] X = new int[n + 1];
            int[] inputArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            
            for (int i = 1; i < n + 1; i++)
            {
                X[0] = 0;
                X[i] = inputArr[i - 1];
            }

            int[] sumArr = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                sumArr[0] = 0;
                sumArr[i] = sumArr[i - 1] + X[i];
            }

            int[] Y = new int[2];
            for (int i = 0; i < m; i++)
            {
                Y = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int result = 0;
                result += sumArr[Y[1]] - sumArr[Y[0] - 1];
                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}