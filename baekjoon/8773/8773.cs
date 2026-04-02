using baekjoon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon._8773
{
    public class _8773: IProblem
    {
        public void Solve()
        {
            int set = int.Parse(Console.ReadLine());
            int[] result = new int[set];

            for (int i = 0; i < set; i++)
            {
                string[] input =  Console.ReadLine().Split(' ');
                int size = int.Parse(input[0]);
                int pos = int.Parse(input[1]);

                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] roop = new int[arr.Length * 2];

                long idx = pos % (2 * size);

                if (idx < size)
                {
                    result[i] = arr[idx];
                }
                else
                {
                    result[i] = arr[2 * size - 1 - idx];
                }

                // 최적화 이전
                /* for (int j = 0; j < arr.Length; j++)
                 {
                     roop[j] = arr[j];
                     roop[j + arr.Length] = arr[arr.Length - 1 - j];
                 }

                 pos = pos % roop.Length;

                 result[i] = roop[pos];*/

            }
            for (int k = 0; k < result.Length; k++)
            {
                Console.WriteLine(result[k]);
            }

        }
    }
}
