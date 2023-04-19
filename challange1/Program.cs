
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange1.variables;

namespace challange1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<task8> tl = new List<task8>();
            int op;
            task8 t = new task8();
            tl.Add(t);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Enter time: ");
                Console.WriteLine("2.Print time: ");
                Console.WriteLine("3.Increment second");
                Console.WriteLine("4.Increment min");
                Console.WriteLine("5.Increment hours");
                Console.WriteLine("6.Compare times");
                Console.WriteLine("7.Elapsed time");
                Console.WriteLine("8.Remaining time");
                Console.WriteLine("9.Distance between clocks");
                Console.WriteLine("0.exit");
                op = int.Parse(Console.ReadLine());
                if (op == 0)
                    break;
                if (op == 1)
                {
                    tl.Add(Enter_time());
                }
                if (op == 2)
                {
                    tl[1].print_time();
                }
                if (op == 3)
                {
                    tl[0].Increment_second();
                }
                if (op == 4)
                {
                    tl[0].Increment_min();
                }
                if (op == 5)
                {
                    tl[0].Increment_hours();
                }
                if (op == 6)
                {
                    Compare_time(tl);
                }
                if(op==7)
                {
                   tl[1].Elapsed_time();
                }
                if(op==8)
                {
                    tl[1].remaining_time();
                }
                if(op==9)
                {
                    distance(tl);
                }
            }
            Console.ReadLine();
        }
        static task8 Enter_time()
        {
            int hrs;
            int min;
            int sec;
            Console.WriteLine("Enter time hr/min/sec: ");
            hrs = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
            task8 t1 = new task8(hrs, min, sec);
            return t1;
        }
        static void Compare_time(List<task8> tl)
        {
            if (tl[0].hours == tl[1].hours && tl[0].mins == tl[1].mins && tl[0].secs == tl[1].secs)
            {
                Console.WriteLine(" true");
            }
            else
                Console.WriteLine("False");
            Console.ReadKey();
        }
        static void distance(List<task8> tl)
        {
            int h, m, s;
            h= (tl[1].hours)-(tl[0].hours);
            m = tl[1].mins - tl[0].mins;
            s = tl[1].secs - tl[0].secs;
            Console.WriteLine("The distance between the two clocks is {0}:{1}:{2}", h, m, s);
            Console.ReadKey();

        }

    }
}
    
