using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15___16_PracticeProblem
{
    internal class FindNearest
    {
        public int FindClosestEvenNumber(int N)
        {
            int closestEvenNumber = 0;

            // Find the closest even number greater than or equal to N
            if (N % 2 == 0)
            {
                closestEvenNumber = N;
            }
            else
            {
                closestEvenNumber = (N > 0) ? N + 1 : N - 1;
            }

            while (!IsAllDigitsEven(closestEvenNumber))
            {
                closestEvenNumber = (N > 0) ? closestEvenNumber + 2 : closestEvenNumber - 2;
            }

            return closestEvenNumber;
        }

        private bool IsAllDigitsEven(int num)
        {
            string numStr = Math.Abs(num).ToString();
            return numStr.All(c => (c - '0') % 2 == 0);
        }
    }
}
