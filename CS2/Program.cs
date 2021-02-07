using System;

namespace CS2
{
    class Program
    {

        #region Events and delegates example
        // class BroadCaster
        // {
        //     // public static event Action<string> Transmint;
        //     public static event Action<object, EventArgs> Transmint;

        //     public void Broadcast(string msg)
        //     {
        //         Transmint(this, new RadioTransmission{message = msg});
        //     }
        // }

        // class RadioTransmission : EventArgs
        // {
        //     public string message;
        // }

        // class Radio
        // {
        //     public Radio()
        //     {
        //         BroadCaster.Transmint += Recieve;
        //     }

        //     public void Recieve(object sender, EventArgs e)
        //     {
        //         var msg = e as RadioTransmission;
        //         System.Console.WriteLine($"Redio says: {msg.message}");
        //     }
        // }
        
        // // public delegate void MyCallbackDelegate(int i, string s);
        // // private static MyCallbackDelegate myCallback = MyCallback;

        // // private Action<int, string> myCallbackAction = MyCallback;
        // private Func<int, string, int> myCallbackWithReturn = MyCallback;

        // static void Main(string[] args)
        // {

        //     // DoSmth(1, "smt", 
        //     //     delegate (int x, string y)
        //     //     {
        //     //         return x;
        //     //     }
        //     // );

        //     // (kintamieji) => { return } 
        //     DoSmth(1, "smt", 
        //         (int x, string y) =>
        //         {
        //             return x;
        //         }
        //     );
        // }


        // static void DoSmth(int code, string name, Func<int, string, int> callback)
        // {
        //     // ...
        //     //Callback
        //     callback(code, name);
        // }

        // static int MyCallback(int a, string b)
        // {
        //     System.Console.WriteLine("Did something");
        //     return 1;
        // }
        #endregion

        #region Method parameter example
        // static void Main(string[] args)
        // {
        //     char a = 'a';
        //     char b = 'b';

        //     Swap(ref a, ref b);

        //     Print(a, b, 'c', 'd');

        //     var c = Combine(a,b);
        //     System.Console.WriteLine(c);

        //     //System.Console.WriteLine($"char a = {a}; \t char b = {b};");     
        // }
        
        // static (char a, char b) Combine(char a, char b)
        // {
        //     return (a, b);
        // }

        // static void Swap(ref char x, ref char y)
        // {
        //     char temp = x;
        //     x = y;
        //     y = temp; 
        // }

        // static void Print(char x, params char[] xx)
        // {
        //     System.Console.WriteLine($"First value is {x}; Other values are:"); 

        //     foreach(var i in xx)
        //     {
        //         System.Console.Write($"{i}; \t");   
        //     }  
        // }
        #endregion

        #region Generics example
        // static void Main(string[] args)
        // {
        //     int a = 1;
        //     float b = 2.0f;
        //     char c = 'C';
        //     string s = "Something";

        //     Print(a);
        //     Print(b);
        //     Print(c);
        //     Print(s);

        //     var p = Create<Program>();
        // }

        // static void Print<T>(T val)
        // {
        //     System.Console.WriteLine(val);
        // }

        // static object Create(Type tInfo)
        // {
        //     // ... 
        //     return new object();
        // }

        // // typeof(Whatever) == Program?
        // static Whatever Create<Whatever>()
        //     where Whatever : new()
        // {
        //     return new Whatever();
        // }
        #endregion

    }
}
