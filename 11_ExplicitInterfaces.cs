using System;

#region 🔷 Interface Declarations

// Interface I1 declares a method with no implementation
interface I1
{
    void InterfaceMethod();
}

// Interface I2 also declares a method with the same name
interface I2
{
    void InterfaceMethod();
}

#endregion

#region 🔷 Class Implementing Both Interfaces

/*
🧠 Explanation:
- When a class inherits two interfaces with same method names,
  it must implement both methods.
- If we implement them normally, compiler gets confused which one to call.
- So we use **Explicit Interface Implementation**.

🟡 Notes:
✔ Explicit implementation means using interface name to define the method
✔ These methods are NOT accessible via class instance directly
✔ You can only access them using interface references or by type casting
✔ No access modifiers (like public/private) are allowed in explicit methods
*/

public class Program : I1, I2
{
    // 🔸 Explicit implementation of I1.InterfaceMethod
    void I1.InterfaceMethod()
    {
        Console.WriteLine("InterfaceMethod from I1 implemented");
    }

    // 🔸 Explicit implementation of I2.InterfaceMethod
    void I2.InterfaceMethod()
    {
        Console.WriteLine("InterfaceMethod from I2 implemented");
    }

    #endregion

    #region 🔷 Main Method

    public static void Main()
    {
        Program P = new Program();

        // ❌ Error: This won't work, class reference can't call explicitly implemented method
        // P.InterfaceMethod();

        // ✔️ Option 1: Using casting to interface
        ((I1)P).InterfaceMethod(); // Output: InterfaceMethod from I1 implemented
        ((I2)P).InterfaceMethod(); // Output: InterfaceMethod from I2 implemented

        Console.WriteLine();

        // ✔️ Option 2: Using interface references
        I1 i1 = new Program();
        I2 i2 = new Program();

        i1.InterfaceMethod(); // Output: InterfaceMethod from I1 implemented
        i2.InterfaceMethod(); // Output: InterfaceMethod from I2 implemented
    }

    #endregion
}
// 📘 Summary
// 📌 What is Explicit Interface Implementation?
// A technique used when:

// A class inherits from two interfaces

// Both interfaces have methods with same name

// The class must implement both without conflict

// 🔐 Key Rules:
// No access modifiers allowed (public, private ❌)

// Must be accessed via casting or interface variable

// Can't call explicitly implemented methods using class object