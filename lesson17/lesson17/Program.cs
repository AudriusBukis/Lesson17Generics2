using Lesson17.Models;
using System;
using System.Collections.Generic;

namespace lesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson 17");

            GenericList2<int> genericList = new (new List<int>() { 1, 2, 3, 4, 5, 6, 1, 1, 7 });
            var findReturntBool = genericList.ElementContainsInList(1);
            var find2 = genericList.FindElement2(8);
            var find = genericList.FindElement2(1);

        }
    }
}
