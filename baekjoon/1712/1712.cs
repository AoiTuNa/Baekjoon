using baekjoon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon._1712
{
    public class _1712 : IProblem
    {
        public void Solve()
        {
            string[] input = Console.ReadLine().Split(' ');
            int investmentCost = int.Parse(input[0]);
            int productionCost = int.Parse(input[1]);
            int saleCost = int.Parse(input[2]);
            
            if (productionCost >= saleCost)
            {
                Console.WriteLine(-1);
                return;
            }

            Console.WriteLine(investmentCost / (saleCost - productionCost) + 1);

        }
        
    }
}
