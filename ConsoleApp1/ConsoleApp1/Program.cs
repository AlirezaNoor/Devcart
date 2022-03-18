using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            List<Class1> myList = new List<Class1>();
            var my = new Class1();
            my.id = 1;
            my.name = "alireza";
            myList.Add(my);
            Console.WriteLine(myList+"sssss");
        }
    }
}
