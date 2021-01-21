using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int popNum = array[1];
            int findNum = array[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var elements = new Queue<int>(numbers);

            for (int i = 0; i < popNum; i++)
            {
                elements.Dequeue();
            }
            if (elements.Contains(findNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elements.Count > 0 ? elements.Min() : 0);
            }
        }
    }
}
