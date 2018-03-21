using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Timer
    {
        

        static void Main(string[] args)
        {
            Timernew timer = new Timernew();
            timer.Sec = Console.ReadLine();
            Console.WriteLine(timer.Sec);
        }
    }
}
