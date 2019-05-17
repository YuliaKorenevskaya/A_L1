using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_L1
{
    public interface IShapes
    {
        void Show();
    }
    class Circle : IShapes
    {
        public int rd;
        public double s;
        public Circle()
        {
            Random rand = new Random();
            rd = rand.Next(1, 10);
            s = rd * rd * 3.14;
            Show();
        }
        public void Show()
        {
            Console.Write($"К-г {s}  ");
        }
    }
    class Rectangle : IShapes
    {
        private int height;
        private int width;
        public double s;
        public Rectangle()
        {
            Random rand = new Random();
            height = rand.Next(1, 10);
            width = rand.Next(1, 10);
            s = height * width;
            Show();
        }
        public void Show()
        {
            Console.Write($"П-к {s}  ");
        }
    }
    class Triangle : IShapes
    {
        private int side;
        private double s;
        public Triangle()
        {
            Random rand = new Random();
            side = rand.Next(1, 10);
            s = side * side * Math.Sqrt(3) / 4;
            Show();
        }
        public void Show()
        {
            Console.Write($"T-к {Math.Round(s, 2)} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[10, 3];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        new Circle();
                    }

                    if (j == 1)
                    {
                        new Rectangle();
                    }

                    if (j == 2)
                    {
                        new Triangle();
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}