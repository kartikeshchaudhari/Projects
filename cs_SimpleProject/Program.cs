using System;

namespace cs_SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Operation On OOPS");
            operation op = new operation();
            double rRaiseTo = op.RaiseTo(10, 3);
            Console.WriteLine($"RaiseTo of given number are {rRaiseTo}");
        }
    }
    public class operation
    {
        private bool Validate(int x, int y)
        {
            if (x == 0 || y == 0)
                return false;
            else
                return true;
        }
        public double RaiseTo(int x, int y)
        {
            if (!Validate(x, y)) return 0;
            double z = Math.Pow(x, y);
            return z;
        }

    }
}
