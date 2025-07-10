using System;

public class Program
{
    public static void Main()
    {
        Add(5, 10);                    // int, int
        Add(3.5f, 2.5f);              // float, float
        Add(5, 10, 15);               // int, int, int
        Add(1, 2, 3, 4);              // int, int, int, int

        int a, b;
        Add(out a, out b);           // Overload using 'out' parameters

        int x = 10, y = 20;
        AddRef(ref x, ref y);        // Overload using 'ref' parameters
    }

    /*
     🔁 Method Overloading in C#
     
     Method overloading allows a class to have multiple methods with the same name 
     but with different **signatures**.

     👉 A method's **signature** includes:
        - Method name
        - Number of parameters
        - Type of parameters (int, float, etc.)
        - Kind of parameters (value, ref, out)

     ⚠️ Signature does **NOT** include:
        - Return type
        - `params` modifier

     ❌ So you can't overload a method just by changing the return type or adding `params`.

     ✅ Examples below:
    */

    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum (int, int) = {0}", (FN + SN));
    }

    public static void Add(float FN, float SN)
    {
        Console.WriteLine("Sum (float, float) = {0}", (FN + SN));
    }

    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum (3 ints) = {0}", (FN + SN + TN));
    }

    public static void Add(int FN, int SN, int TN, int FourthNumber)
    {
        Console.WriteLine("Sum (4 ints) = {0}", (FN + SN + TN + FourthNumber));
    }

    public static void Add(out int a, out int b)
    {
        a = 100;
        b = 200;
        Console.WriteLine("Sum (out): {0}", a + b);
    }

    public static void AddRef(ref int a, ref int b)
    {
        a += 5;
        b += 5;
        Console.WriteLine("Sum (ref): {0}", a + b);
    }
}
