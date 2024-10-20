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
            string input;
            input = Console.ReadLine();
            int n = int.Parse(input);

            string[] inputArr = Console.ReadLine().Split();

            List<int> A = new List<int>();
            foreach(string a in inputArr)
            {
                A.Add(int.Parse(a));
            }
            A.Sort();

            input = Console.ReadLine();
            int m = int.Parse(input);
            inputArr = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputArr.Length; i++)
            {
                int search = int.Parse(inputArr[i]);
                int start = 0;
                int end = A.Count - 1;
                int middle = 0;

                while(true)
                {
                    middle = (start + end) / 2;
                    if(middle == start)
                    {
                        if (A[start] == search || A[end] == search)
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;
                    }
                    else if (A[middle] == search)
                    {
                        sb.AppendLine("1");
                        break;
                    }
                    else if(A[middle] > search)
                    {
                        end = middle;
                    }
                    else if(A[middle] < search)
                    {
                        start = middle;
                    }
                }
            }

            Console.WriteLine(sb);

        }
    }
}