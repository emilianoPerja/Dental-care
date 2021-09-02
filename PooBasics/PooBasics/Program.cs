using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PooBasics
{
    class Box
    {
        public int width;
        public int length;
        public int height;

        public static int CalculateVolume(Box box) =>
            box.width * box.length * box.height;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();
            b1.width = 1; b1.length = 2; b1.height = 2;
            b2.width = 3; b2.length = 5; b2.height = 0;
            b3.width = 2; b3.length = 1; b3.height = -4;

            Box[] boxes = new Box[] { b1, b2, b3 };
            foreach (Box box in boxes)
            {
                WriteLine($"Volume: {Box.CalculateVolume(box)}");
            }
        }
    }
}
