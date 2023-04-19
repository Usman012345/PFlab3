using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task1.variables;
using System.Threading.Tasks;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Variables v = new Variables();
            Console.WriteLine("Enter task number");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
                task11.write();
            if (option == 2)
            {
                task2 t = new task2();
                
            }
            if(option==3)
            {
                task3 t = new task3();
                Console.WriteLine(t.sname);
            }
            if(option==4)
            {
                task4 t = new task4();
                Console.WriteLine( t.aggregate);
                Console.WriteLine(t.ecatmarks);
                Console.WriteLine(t.fscmarks);
                Console.WriteLine(t.matricmarks);
                Console.WriteLine(t.sname);
                task4 t1 = new task4();
                Console.WriteLine(t1.aggregate);
                Console.WriteLine(t1.ecatmarks);
                Console.WriteLine(t1.fscmarks);
                Console.WriteLine(t1.matricmarks);
                Console.WriteLine(t1.sname);

            }
            if(option==5)
            {
                task5 t = new task5("Usman");
                Console.WriteLine(t.sname);
                task5 t1 = new task5("1.Shahs");
                Console.WriteLine(t1.sname);

            }
            if(option==6)
            {
                task6 t = new task6("john",213,123,231,132);
                Console.WriteLine(t.aggregate);
                Console.WriteLine(t.ecatmarks);
                Console.WriteLine(t.fscmarks);
                Console.WriteLine(t.matricmarks);
                Console.WriteLine(t.sname);
                task6 t1 = new task6("jack", 21, 123, 123, 435);
                Console.WriteLine(t1.aggregate);
                Console.WriteLine(t1.ecatmarks);
                Console.WriteLine(t1.fscmarks);
                Console.WriteLine(t1.matricmarks);
                Console.WriteLine(t1.sname);
            }
            if(option==7)
            {
                task7 t = new task7();
                t.print();
            }
            if (option == 8)
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
           hrs=int.Parse( Console.ReadLine());
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
        


    }
}
