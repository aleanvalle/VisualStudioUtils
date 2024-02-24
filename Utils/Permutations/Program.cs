namespace Permutations
{
    public class Program
    {
        bool IsOdd(int number)
        {
            return number % 2 == 1;
        }

        void Swap<T>(T[] elementsToPermute, int a, int b)
        {
            T temp = elementsToPermute[a];
            elementsToPermute[a] = elementsToPermute[b];
            elementsToPermute[b] = temp;
        }

        public T[][] GetPermutations<T>(T[] elementsToPermute, int n)
        {
            List<List<T>> permutations = new List<List<T>>();
            if (n == 1)
            {
                permutations.Add(elementsToPermute.ToList());
                return permutations.Select(l => l.ToArray()).ToArray();
            }
            int[] index = new int[n];
            for (int i = 0; i < n; i++)
            {
                index[i] = 0;
            }
            permutations.Add(elementsToPermute.ToList());
            for (int i = 1; i < n;)
            {
                if (index[i] < i)
                {
                    if (IsOdd(i))
                    {
                        Swap(elementsToPermute, i, index[i]);
                    }
                    else
                    {
                        Swap(elementsToPermute, i, 0);
                    }
                    permutations.Add(elementsToPermute.ToList());
                    index[i]++;
                    i = 1;
                }
                else
                {
                    index[i++] = 0;
                }
            }
            return permutations.Select(l => l.ToArray()).ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
