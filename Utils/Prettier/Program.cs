namespace Prettier
{
    public class Program
    {
        public void PrintArray<T>(T[] arr)
        {
            int arrLength = arr.Length;
            Console.Write("[");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(string.Format("{0}", arr[i]));
                if (i + 1 != arrLength)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("]");
                }
            }
            return;
        }

        public void PrintMatrix<T>(T[][] arr)
        {
            int rowLength = arr.Length;
            int colLength = arr[0].Length;
            Console.Write("[");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("[");
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}", arr[i][j]));
                    if (j + 1 != colLength)
                    {
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write("]");
                    }
                }
                if (i + 1 != rowLength)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("]");
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string[] b = { "abc", "def", "ghi" };
            a.PrintArray(b);
        }
    }
}
