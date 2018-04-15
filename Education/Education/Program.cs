﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 1;
            p1.sym = '*';

            Draw(p1.x, p1.y, p1.sym);

            Console.ReadKey();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
