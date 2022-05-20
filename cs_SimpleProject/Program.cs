using System;

namespace cs_SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Cos(90));
            Console.WriteLine("Basic Operation On OOPS");
            operation op = new operation();
            double rRaiseTo = op.RaiseTo(10, 3);
            Console.WriteLine($"RaiseTo of given number are {rRaiseTo}");
            int rfactorial = op.factorial(5);
            Console.WriteLine($"Factorial Of given No is{rfactorial}");
            Console.WriteLine();


            double return_value = op.area("circle", new double[] { 10, 5, 5 });
            double return_value1 = op.area("rectangle", new double[] { 10, 5, 5 });
            double return_value2 = op.area("elipse", new double[] { 10, 5, 5 });
            double return_value3 = op.area("triangle", new double[] { 10, 5, 5 });
            double return_value4 = op.area("square", new double[] { 10, 5, 5 });

            Console.WriteLine($" Area of circle = {return_value}");
            Console.WriteLine($" Area of rectangle = {return_value1}");
            Console.WriteLine($" Area of elipse = {return_value2}");
            Console.WriteLine($" Area of triangle = {return_value3}");
            Console.WriteLine($" Area of  square = {return_value4}");

            double trignotype = op.Trignotype("cos", 90);
            double trignotype1 = op.Trignotype("sin", 45);
            double trignotype2 = op.Trignotype("tan", 60);

            Console.WriteLine(trignotype);
            Console.WriteLine(trignotype1);
            Console.WriteLine(trignotype2);
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
        
        public double Trignotype(string x,double y)
        {
            if (x == "cos")
            {
                //double cos = Math.Cos(y);
                return Math.Cos(y);
            }
            else if (x == "sin")
            {
                //double cos = Math.Sin(y);
                return Math.Sin(y);
            }
            else if (x == "tan")
            {
                //double cos = Math.Tan(y);
                return Math.Tan(y);
            }
            else return 0;
        }
        public double RaiseTo(int x, int y)
        {
            if (!Validate(x, y)) return 0;
            double z = Math.Pow(x, y);
            return z;
        }
        public int factorial(int x)
        {
            int fact = 1;
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            fact = num;
            for (int i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        public double area(string shape, double[] dimension)
        {
            if (shape == "circle")
            {
                return 3.14 * dimension[0] * dimension[0];
            }
            else if (shape == "rectangle")
            {
                return dimension[1] * dimension[2];

            }
            else if (shape == "elips")
            {
                return 3.14 * dimension[1] * dimension[2];
            }
            else if (shape == "triangle")
            {
                return 0.5 * dimension[1] * dimension[2];
            }
            else
            {
                return dimension[1] * dimension[2];
            }


        }

        
    }
}
