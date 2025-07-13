using System;

//
// 🔸 Abstract class:
// An abstract class is incomplete and hence cannot be instantiated.
// It is designed to be inherited and act as a base class.
//
public abstract class Customer
{
    //
    // 🔹 Abstract method (no body):
    // This method must be implemented by any non-abstract class that inherits this class.
    //
    public abstract void Print();
}

//
// 🔸 Derived non-abstract class:
// This class inherits from Customer and provides implementation for the abstract method.
//
public class Program : Customer
{
    //
    // ✅ Implementing the abstract Print method
    //
    public override void Print()
    {
        Console.WriteLine("Print Method");
    }

    public static void Main()
    {
        //
        // ❌ Not allowed: Cannot create an instance of abstract class
        // Customer obj = new Customer();

        //
        // ✅ Allowed: Create an object of derived class and assign to abstract type (Polymorphism)
        //
        Customer C = new Program();
        C.Print(); // Output: Print Method
    }
}


//
// 🔸 Summary:
// • An abstract class can only be used as a base class.
// • An abstract class cannot be sealed.
// • An abstract class may contain abstract members (methods, properties, indexers, and events), but it's not mandatory.
// • A non-abstract class derived from an abstract class must implement all inherited abstract members.
//
// 🔸 If a class inherits an abstract class, there are 2 options:
//
// Option 1: Provide implementation for all abstract members inherited from the base abstract class.
// Option 2: If not providing all implementations, mark the derived class itself as abstract.
//
