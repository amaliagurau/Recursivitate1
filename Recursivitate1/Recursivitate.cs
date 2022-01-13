using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursivitate1
{
    public static class Recursiv
    {
        public static void ParcurgereVector(int[] vector, int n)
        {
            if (n == 1)
                Console.WriteLine(vector[n - 1]);
            else
            {

                ParcurgereVector(vector, n - 1);
                Console.WriteLine(vector[n - 1]);

            }
        }
    }
}
