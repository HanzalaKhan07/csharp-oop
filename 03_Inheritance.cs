using System;

// --------------------------------------------------------------
// ✅ INHERITANCE IN C#
// --------------------------------------------------------------

// ✔ Base class (also called Parent class)
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    // Method to print full name
    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

// ✔ Derived class from Employee (inherits all public members)
public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

// ✔ Another derived class from Employee
public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

// ✔ Multi-level Inheritance (A → PartTimeEmployee → Employee)
public class A : PartTimeEmployee
{
    // Inherits everything from PartTimeEmployee and Employee
}

public class Program
{
    public static void Main()
    {
        // Using FullTimeEmployee
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Hanzala";
        FTE.LastName = "Shaukat";
        FTE.YearlySalary = 1000000;
        FTE.PrintFullName(); // Output: Hanzala Shaukat

        // Using PartTimeEmployee
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Junaid";
        PTE.LastName = "Shaukat";
        PTE.HourlyRate = 1000;
        PTE.PrintFullName(); // Output: Junaid Shaukat

        // Using Class A (multi-level inheritance)
        A A1 = new A();
        A1.FirstName = "Bilal";
        A1.LastName = "Shaukat";
        A1.PrintFullName(); // Output: Bilal Shaukat
    }
}

// -----------------------------------------------------------------------------
// 📘 SUMMARY OF CONCEPTS – INHERITANCE
// -----------------------------------------------------------------------------

// 1️⃣ Inheritance allows one class (child) to reuse the members of another class (parent).

// 2️⃣ Syntax:
//     public class Parent { /* parent code */ }
//     public class Child : Parent { /* child code */ }

// 3️⃣ C# supports single class inheritance only.
//     ✔ You can inherit from only ONE class.
//     ✖ Not allowed: class Parent : Child, Child (error)

// 4️⃣ C# supports multiple interface inheritance.

// 5️⃣ Child class is a specialization of base class.

// 6️⃣ Base classes are automatically instantiated before derived classes.
//     ✔ Constructors of base class run first.

// 7️⃣ Parent Class constructor executes before Child Class constructor.
//     ✔ This ensures that the base fields are initialized first.