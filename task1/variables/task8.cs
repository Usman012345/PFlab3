using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.variables
{
    class task8
    {
        public int hours;
        public int mins;
        public int secs;
        public task8()
        {

        }
       public task8(int hours,int mins,int secs)
        {
            this.hours = hours;
            this.mins = mins;
            this.secs = secs;
        }
       public void  print_time()
        {
            Console.WriteLine("The time is {0}:{1}:{2}",hours, mins, secs);
            Console.ReadKey();
        }
        public void Increment_second()
        {
            secs++;
        }
        public void Increment_min()
        {
            mins++;
        }
        public void Increment_hours()
        {
            hours++;
        }
    }
}
