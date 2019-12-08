using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface ICoordinable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int[,] matrix);
    }
}
