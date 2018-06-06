using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    // butterfly program on odd numbers
    class Program
    {
        static void Main(string[] args)
        {
            int r, h, d, sp;
            Console.Write("enter a number:");
            h = int.Parse(Console.ReadLine());
            h += 2;
            for (r = 1; r <= h - 1; r+=2)
            {
                for (d = 1; d <= r; d+=2)
                        Console.Write(d);
                        Console.Write("\t");
                        for (sp = 1; sp <= 2 * (h - r); sp++)
                            Console.Write("");
                        for (d = r; d >= 1; d-=2)
                            Console.Write(d);
                        Console.Write("\n");
                    
                  
            }
            for (r = h; r >= 1; r-=2)
            {
                for (d = 1; d <= r; d+=2)
                 
                        Console.Write(d);
                        Console.Write("\t");
                        for (sp = 1; sp <= 2 * (h - r); sp++)
                            Console.WriteLine("");
                        for (d = r; d >= 1; d-=2)
                            Console.Write(d);
                        Console.Write("\n");
                    
                  
            }
        }
    }
}
