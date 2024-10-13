namespace _2539
{
    class Program
    {
        static int horizontal;
        static int ColorP;
        static int CP = 0;
        static int[] hori;
        static void Main(string[] args)
        {
            _1219();
        }
        static void _1219()
        {

            int incorrect;
            string input = null;

            input = Console.ReadLine();
            string[] vh = input.Split(" ");
            horizontal = int.Parse(vh[1]);

            ColorP = int.Parse(Console.ReadLine());
            incorrect = int.Parse(Console.ReadLine());
            hori = new int[horizontal];
            for (int i = 0; i < horizontal; i++)
            {
                hori[i] = 0;
            }
            for (int i = 0; i < incorrect; i++)
            {
                input = Console.ReadLine();
                string[] str = input.Split(" ");
                if (int.Parse(str[0]) > CP)
                {
                    CP = int.Parse(str[0]);
                }
                hori[int.Parse(str[1]) - 1] = int.Parse(str[0]);
            }
            Search();
        }
        static void Search()
        {
            int low = CP;
            int high = horizontal;
            int mid = 0;
            while (low < high)
            {
                mid = (low + high) / 2;

                int pCnt = Check(mid);
                if (pCnt > ColorP)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            Console.WriteLine(high);
        }
        static int Check(int size)
        {
            int pCount = 0;
            for (int i = 0; i < horizontal; i++)
            {
                if (hori[i] != 0)
                {
                    if (hori[i] <= size)
                    {
                        i = i + size - 1;
                        pCount++;
                    }
                    else
                    {
                        pCount++;
                    }
                }
            }
            return pCount;
        }
    }
}