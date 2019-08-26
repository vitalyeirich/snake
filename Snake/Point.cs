using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int Rx, int Ry, char Rsym)
        {
            x = Rx;
            y = Ry;
            sym = Rsym;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
