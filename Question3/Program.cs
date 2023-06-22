using System;

namespace ProblemSet
{
    class Question3
    {
        static void Main(string[] args)
        {
            
            double s, a, b, c, AreaOfTriangle;

            
            Console.WriteLine("Enter the values of a, b, c: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            
            s = (a + b + c) / 2;

           
            AreaOfTriangle = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            
            Console.WriteLine("Area of triangle is " + AreaOfTriangle);
            Console.ReadLine();
        }
    }
}
