using System;

//
// 🔸 Abstract class:
// Can contain fields, constructors, implemented methods, and abstract members.
//
public abstract class Customer
{
    // ✅ Fields are allowed in abstract classes
    int ID;

    // ✅ Non-abstract method with implementation
    public void Print()
    {
        Console.WriteLine("Print from abstract class");
    }
}

//
// 🔸 Interface:
// Cannot contain fields or constructors.
// Only declarations (no implementation) before C# 8.
//
public interface ICustomer
{
    // ❌ Not allowed: Fields in interfaces
    // int ID;

    // ✅ Only method signature (must be public implicitly)
    void Print();
}

//
// 🔸 Main program to demonstrate structure
//
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Demo for Abstract Class vs Interface");

        // Note: We can't instantiate abstract classes or interfaces directly.
    }
}


// 🔹 Summary: Abstract Class vs Interface

// ✅ An interface can inherit from another interface ONLY.
// ❌ An interface CANNOT inherit from an abstract class.

// ✅ An abstract class CAN inherit from:
//    - Another abstract class
//    - One or more interfaces

// ✅ A class can inherit from MULTIPLE interfaces.
// ❌ A class CANNOT inherit from multiple classes (no multiple inheritance).

// Example:
//
// public class MyClass : AbstractBase, IInterface1, IInterface2
