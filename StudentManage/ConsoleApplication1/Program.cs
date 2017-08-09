using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //Console.WriteLine("DotNet.Utilities.Rmb.CmycurD(\"1432495.5612\")" + DotNet.Utilities.Rmb.CmycurD("1000001.5612"));
            Class1 c = new Class1();

            Console.WriteLine(c.GetPYString("打"));
            Console.ReadKey();
        }
    }
}
