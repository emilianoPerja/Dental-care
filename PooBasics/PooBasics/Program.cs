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
        private int width;
        private int length;
        private int height;

        public int Width
        {
            get => width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value");
                }

                width = value;
            }
        }

        public int Length
        {
            get => length;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value");
                }

                length = value;
            }
        }

        public int Height
        {
            get => height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("value");
                }

                height = value;
            }
        }

        /*
        public int GetWidth() => width;

        public void SetWidth(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("value");
            }

            width = value;
        }
        */

        public static int CalculateVolume(Box box) =>
            box.width * box.length * box.height;

        public Box()
        {
            Width = 1;
            Length = 1;
            Height = 1;
        }

        public Box(int size)
        {
            Width = size;
            Length = size;
            Height = size;
        }

        public Box(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(1, 2, 2);
            Box b2 = new Box(2, 5, 1);
            Box b3 = new Box(3, 1, 4);
            Box b4 = new Box(5);

            Box[] boxes = new Box[] { b1, b2, b3, b4 };
            foreach (Box box in boxes)
            {
                WriteLine($"Volume: {Box.CalculateVolume(box)}");
            }

            /*
            b1.Width = 3;
            //b1.SetWidth(b1.GetWidth() + 1);
            b1.Width++;
            Console.WriteLine($"width = {b1.Width}");

            b1.SetWidth(3);
            Console.WriteLine($"width = {b1.GetWidth()}");

            //b1.width++;
            b1.SetWidth(b1.GetWidth() + 1);
            //b2.length = b1.width++ + b3.width--;
            */
        }
    }
}
