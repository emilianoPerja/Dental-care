using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace PooBasics
{
    struct Box
    {
        public int width;
        public int length;
        public int height;
    }

    class Program
    {
        static int CalculateVolume(Box box) =>
            box.width * box.length * box.height;

        static void Main(string[] args)
        {
            Box b1, b2, b3;
            b1.width = 1; b1.length = 2; b1.height = 2;
            b2.width = 3; b2.length = 5; b2.height = 3;
            b3.width = 2; b3.length = 1; b3.height = 4;

            Box[] boxes = { b1, b2, b3 };
            foreach (Box box in boxes)
            {
                WriteLine($"Volume: {CalculateVolume(box)}");
            }
        }
    }
}
