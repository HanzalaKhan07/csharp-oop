/*
📘 Difference Between Method Overriding & Method Hiding in C#

✔ Method Overriding:
- Uses 'virtual' in base class and 'override' in child class.
- Runs based on object type (runtime polymorphism).

✔ Method Hiding:
- Uses 'new' keyword in child class.
- Runs based on reference type (compile-time behavior).

🧠 Base b = new Derived();
- If method is overridden → child method runs.
- If method is hidden → base method runs.

*/

using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base Class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    // Change this to test either overriding or hiding

    // For Method Overriding:
    // public override void Print()

    // For Method Hiding:
    public new void Print()
    {
        Console.WriteLine("Child Class Print Method");
    }
}

public class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print(); // Output depends on whether override or new is used
    }
}
