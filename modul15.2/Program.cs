﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type console = typeof(Console);
            MethodInfo[] methods = console.GetMethods();
            Console.WriteLine("Список методов класса Console: \n");
            foreach (MethodInfo m in methods)
            {
                Console.Write(m.ReturnType.Name + "\t" + m.Name);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
