
using System;

public class ForEachLoop
{
    public static void ForEach(string[] args)
    {
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        Console.WriteLine("Fruits in the array:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

// Notes For ForEach Loop in C#:
// A foreach loop in C# is a control flow statement that allows you to iterate over a collection of items, such as an array or a list, without needing to manage the index variable. The syntax for a foreach loop is as follows:
// foreach (type variable in collection)
// {
// Code to be executed
// }
// The foreach loop iterates through each element in the specified collection, assigning the current element to the variable declared in the loop. The code inside the loop is executed for each element in the collection. This makes it a convenient and readable way to process items in a collection without worrying about the underlying structure or index management. It is important to note that you cannot modify the collection while iterating through it with a foreach loop, as it may lead to runtime exceptions.
