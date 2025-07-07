//  ✅ Before (Problem with Public Fields):

/*🔴 Problem:
ID can be negative ❌
Name can be null ❌
No default value like "No Name" ❌
PassMark should be read-only ❌ 
*/

// ✅ After (Encapsulation with Getter and Setter Methods):
using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    // Setter & Getter for Id
    public void SetId(int id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id cannnot be negative");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }

    // Setter & Getter for Name
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._Name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
    }

    // Only Getter for PassMark (read-only)
    public int GetPassMark()
    {
        return this._passMark;
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.SetId(101);
        C1.SetName("Hanzala");
        Console.WriteLine("Student Id = {0}", C1.GetId());
        Console.WriteLine("Student Name = {0}", C1.GetName());
        Console.WriteLine("Student PassMark = {0}", C1.GetPassMark());
    }
}
