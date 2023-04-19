using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1.variables
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
        public void Elapsed_time()
        {
            int elapsed;
            elapsed = hours * 3600 + mins * 60 + secs;
            Console.WriteLine("The elapsed time is: {0}",elapsed);
            Console.ReadKey();
        }
        public void remaining_time()
        {
            int h, m, s,remaining;
            h = 24 - hours;
            m = 60 - mins;
            s = 60-secs;
            remaining = h + m + s;
            Console.WriteLine("The remianing time is {0}", remaining);
            Console.ReadKey();
        }
    }
}
