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
            int input;
            int Length = int.Parse(Console.ReadLine());
            int[] inputVar = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                input = int.Parse(Console.ReadLine());
                inputVar[i] = input;
            }
            inputVar = inputVar.Distinct().ToArray();
            Array.Sort(inputVar);

            StringBuilder result = new StringBuilder(String.Join("\n", inputVar));

            Console.WriteLine(result);
        }
    }
}