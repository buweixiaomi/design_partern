using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            Singleton.Partern.Test3.GGG();
            Singleton.Partern.Test3.GetInstance();
            Console.Read();
        }
    }
}
