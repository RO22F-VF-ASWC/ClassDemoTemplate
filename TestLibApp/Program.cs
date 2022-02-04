using System;
using MyLib;

namespace TestLibApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            try
            {
                sc.SomeMethod(6, "3");
            }
            catch (Exception e)
            {

            }

            Console.WriteLine("Hello World!");
        }
    }
}
