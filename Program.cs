using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Width = 10;
            rec.Height = 10;
            System.Console.WriteLine(rec.CalculateArea());
        }
    }
}
