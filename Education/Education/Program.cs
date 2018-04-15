using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'*');
            
            p1.Draw();

            Console.ReadKey();
        }
        
    }
}
