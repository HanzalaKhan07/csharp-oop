// 📚 C# Properties - Encapsulation Example

/*
🧠 What You'll Learn from This Example:
--------------------------------------
✔️ Read/Write Properties:
   - Has both `get` and `set` accessors.
   - Used for fields like `Id` and `Name`.
   - Validates input before storing.

✔️ Read-Only Properties:
   - Only `get` accessor (no `set`).
   - Example: `PassMark` – constant read-only value.

✔️ Write-Only Properties:
   - Only `set` accessor.
   - Used when input is required but not read back.

✔️ Auto-Implemented Properties:
   - Used for simple values (like `Email`, `City`) with no validation.
*/

using System;

public class Student
{
    // 🔒 Private fields for encapsulation
    private int _id;
    private string _Name;
    private int _passMark = 35;
    private string _email;
    private string _city;

    // ⚡ Auto-implemented Properties (no validation needed)
    public string Email { get; set; }
    public string City { get; set; }

    // 🔁 Read/Write Property with validation
    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student Id cannot be negative.");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    // 🔁 Read/Write Property with fallback (default if empty)
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty.");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }

    // 🔒 Read-only Property (get only)
    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
}

// 🚀 Main entry point
public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.Name = "Hanzala";
        C1.City = "Islamabad";
        C1.Email = "hanzala.connect@gmail.com";

        Console.WriteLine("Student Id       = {0}", C1.Id);
        Console.WriteLine("Student Name     = {0}", C1.Name);
        Console.WriteLine("Student PassMark = {0}", C1.PassMark);
        Console.WriteLine("Student City     = {0}", C1.City);
        Console.WriteLine("Student Email    = {0}", C1.Email);
    }
}
