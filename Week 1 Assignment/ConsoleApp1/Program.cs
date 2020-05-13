using System;

namespace ConsoleApp1
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.. blah blah blah!");

            Console.Write("Enter first x value: ");
            float x1 = float.Parse(Console.ReadLine());

            Console.Write("Enter first y value: ");
            float y1 = float.Parse(Console.ReadLine());

            Console.Write("Enter second x value: ");
            float x2 = float.Parse(Console.ReadLine());

            Console.Write("Enter second y value: ");
            float y2 = float.Parse(Console.ReadLine());

            Test t = new Test();

            Console.WriteLine("Distance between points: " + Math.Round(t.dist(x1, y1, x2, y2), 3));
            Console.WriteLine("Angle between points: " + Math.Round(t.angle(x1, y1, x2, y2), 3) + " degrees");
        }

        float dist(float x1, float y1, float x2, float y2)
        {
            return (float) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        float angle(float x1, float y1, float x2, float y2)
        {
            return (float) (Math.Atan2(x2 - x1, y2 - y1) * 180 / Math.PI);
        }
    }
}