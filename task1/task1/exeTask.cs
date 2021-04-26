using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class exeTask
    {
        public int N = 10;        

        public void task1()
        {
            Console.WriteLine("task1:");
            int[] arr = new int[N];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = (int)Math.Pow(2.0, i);
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.Write('\n');
        }

        public void task2()
        {
            Console.WriteLine("task2:\nИсходный массив");
            Random rnd = new Random(14);
            List<int> arr = new List<int>(N);
            for (int i = 0; i < N; i++)
            {
                arr.Add(rnd.Next(0, 100));
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            int min, max;
            int indexMin, indexMax;
            min = arr.Min();
            max = arr.Max();
            indexMin = arr.IndexOf(min);
            indexMax = arr.IndexOf(max);
            int tmp = arr[indexMin];
            arr[indexMin] = arr[indexMax];
            arr[indexMax] = tmp;
            Console.Write("\nmin = {0}, max = {1}\n\nОтсортированный массив\n", min, max);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.Write('\n');
        }

        public void task3()
        {
            Console.WriteLine("task3:\nИсходный массив");
            Random rnd = new Random(14);
            List<int> arr = new List<int>(N);
            for (int i = 0; i < N; i++)
            {
                arr.Add(rnd.Next(0, 100));
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            double average;
            average = (double)arr.Sum() / arr.Count;
            Console.Write("\nСреднее по массиву: {0}\n", average);
        }
    }
}
