using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfMeals = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var serveredOrders = new Queue<int>(orders);

            Console.WriteLine(orders.Max());

            while (serveredOrders.Any())
            {
                if (serveredOrders.Peek() <= amountOfMeals)
                {
                    amountOfMeals -= serveredOrders.Dequeue();
                    continue;
                }
                Console.WriteLine($"Orders left: {string.Join(' ', serveredOrders)}");
                break;
            }
            if (serveredOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
