using System;
using System.Reflection;
using System.Collections.Generic;
using static System.Math;

namespace CS1
{
    class Program
    {
        public static string MyProperty { get; private set; }

        class A
        {
            public int a = 0;
        }; // Tarkim 32 bit

        class B : A
        {
            public int b = 1;
        }; // tarkim 64 bit
        
        static void Main(string[] args)
        {
            // int i = 0;
            // double d = i;
            
            // A a = new B();
            // B b = new B();

            #region if ir trinaris
            // if(args.Length > 10)
            //     System.Console.WriteLine("2");
            // else if(args.Length > 0)
            //     System.Console.WriteLine("1");
            // else
            //     System.Console.WriteLine("");

            // System.Console.WriteLine(args.Length > 10 ? "2" : args.Length > 0 ? "1" : "");
            #endregion 

            #region Trinaris operatorius fore
            // int? input = 0; // null
            
            // for(int i = (input == null ? 10 : input.Value); i < 10; i++)
            // {

            // }
            #endregion
            
            #region Tuscio priskirimo operatoriai
            // int? input  = null;
            // int i = input ?? default(int);
            // input ??= 10;
            #endregion

            #region Overriding
            //Variantas su paslepimu
            // Ferrari f = new Ferrari();
            // Car c = new Ferrari();

            // f.Move() // It moves fast!;
            // c.Move() // It moves;

            // Variantas su overriding
            // Car f = new Ferrari();
            // Car c = new Car();

            // f.Move() // It moves fast!;
            // c.Move() // It moves;
            #endregion

            #region Prin methods
            // System.Console.WriteLine();
            // foreach(var m in typeof(Program).GetTypeInfo().DeclaredMethods)
            // {
            //     System.Console.WriteLine(m);
            // }
            #endregion

            
        }

    }
}
