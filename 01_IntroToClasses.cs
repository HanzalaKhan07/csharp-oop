using System;

class Customer
// A class is a blueprint to create objects. It can contain fields, constructors, methods, and destructors.
{
    // ✅ Fields - store data for each object
    string _firstName;
    string _lastName;

    // Default constructor (no parameters)
    // Calls the parameterized constructor with default values
    public Customer()
        : this("No FirstName Provided", "No LastName Provided")
    {
    }

    // ✅ Parameterized Constructor (Overloaded)
    // Used to initialize the object with specific values
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName; // "this." refers to the current object's fields
        this._lastName = LastName;
    }

    // ✅ Method to print full name
    public void PrintFullName()
    {
        Console.WriteLine("Full Name: {0}", this._firstName + " " + this._lastName);
    }

    // ✅ Destructor (Finalizer)
    // Automatically called when the object is garbage collected
    ~Customer()
    {
        // Clean-up code goes here (not used often in practice)
    }
}

class Program
{
    public static void Main()
    {
        // Creating object using default constructor
        Customer C1 = new Customer();
        C1.PrintFullName(); // Output: No FirstName Provided No LastName Provided

        // Creating object using parameterized constructor
        Customer C2 = new Customer("Hanzala", "Shaukat");
        C2.PrintFullName(); // Output: Hanzala Shaukat
    }
}


// -----------------------------------------------------------------------------
// 📘 SUMMARY OF CONCEPTS
// -----------------------------------------------------------------------------

// ✅ Class:
// A class is like a blueprint. We use it to create objects with fields and methods.

// ✅ Object:
// An instance of a class. Example: Customer C1 = new Customer();

// ✅ Constructor:
// A special method that runs when an object is created.
// Used to set initial values. Can be default (no parameters) or parameterized.

// ✅ Constructor Overloading:
// Creating multiple constructors with different parameter lists.

// ✅ this Keyword:
// Refers to the current object. Helps avoid naming confusion between fields and parameters.

// ✅ Constructor Chaining:
// One constructor calls another using `this(...)` to reuse logic and avoid duplication.

// ✅ Destructor:
// Cleans up resources when the object is destroyed (rarely used in most C# apps).
