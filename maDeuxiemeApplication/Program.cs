using System;
using System.Linq;

namespace maDeuxiemeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = random.Next(1, 49);
                if (!array.Contains(randomNumber))
                {
                    array[i] = randomNumber;
                }
            }
            Result(array);
        }
        static void Result(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
