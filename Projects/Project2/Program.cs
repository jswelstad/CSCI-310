using System;
using System.Xml.Xsl;

namespace PointCalculator
{

    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({this.X}, {this.Y})");
        }

        public static Point operator +(Point right, Point left)
        {
            int newX = right.X + left.X;
            int newY = right.Y + left.Y;
            
            return new Point(newX, newY);
        }
        
        public static Point operator *(Point left, int scale)
        {
            return new Point(left.X * scale, left.Y * scale);
        }

        public static Point operator *(Point left, Point right)
        {
            return new Point(left.X * right.X, left.Y * right.Y);
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }

        public static bool operator ==(Point left, Point right)
        {
            if (left.X == right.X && left.Y == right.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
    
    public class PointCalculator
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 3);
            Point p2 = new Point(4, 7);
            Console.WriteLine($"Created 2 points: {p1}, {p2}");
            
            //Adding
            Console.WriteLine("Adding:");
            Console.WriteLine($"{p1} + {p2} = {p1 + p2}");
            
            //Scaling
            Console.WriteLine("Scaling");
            Console.WriteLine($"Scaling {p1} by 2: {p1 * 2}");
            
            //Multiplying
            Console.WriteLine("Multiplying");
            Console.WriteLine($"{p1} * {p2} = {p1 * p2}");
            
            //Comparison
            Console.WriteLine("Comparing points");
            Console.WriteLine($"{p1} == {p2} = {p1 == p2}");
            Console.WriteLine($"{p1} != {p2} = {p1 != p2}");
            
            
        }
    }
}

