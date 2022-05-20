using System;
using System.Collections;

namespace ConsoleApp2
{
   internal class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection List");
            ArrayList arrList = new ArrayList();
            arrList.Add(11);
            arrList.Add(22);
            arrList.Add(33);
            arrList.Add(44);

            arrList.Add(2.5);
            arrList.Add(3.5);
            arrList.Add(4.5);
            arrList.Add(5.5);


            arrList.Add("kartik");
            arrList.Add("satyam");
            arrList.Add("prajwal");
            arrList.Add("saurabh");

            arrList.Add('A');
            arrList.Add('B');
            arrList.Add('C');
            arrList.Add('D');
            int sum = 0;
            int count = 0;
            Console.WriteLine($"Length of array list = {arrList.Count}");
            foreach (object item in arrList)
            {
                if (item is int)
                {
                    sum = sum + (int)item;
                    if((int)item%2==0)
                    {
                        Console.WriteLine("Even Number = "+(int)item);
                        count++;
                        Console.WriteLine();
                    }
                }
                else if(item is string)
                {
                    string item1 = (string)item;
                    //Console.WriteLine("String Name ="+(string)item+" ,String Length =" + item1.Length + " , Index = " + arrList.IndexOf((string)item));
                    Console.WriteLine($"String Name = {(string)item} ");
                    Console.WriteLine($"String Length = { item1.Length}");
                    Console.WriteLine($"Index = { arrList.IndexOf((string)item)}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Int sum =" + sum);
            Console.WriteLine();
            Console.WriteLine($"Count of  even numbers are { count}");
            


        }
    }
}
