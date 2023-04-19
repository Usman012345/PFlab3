using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.variables
{
    class task7
    {
        public void print()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int x in number)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
