using System;

public class DoWhileLoop
{
    public static void doWhile()
    {
        int count = 0;
        do
        {
            Console.WriteLine("Count: " + count);
            count++;
        } while (count < 5);
    }
}

// notes For Do-While Loop in C#:
// A do-while loop in C# is a control flow statement that allows you to execute a block of code at least once, and then repeatedly execute it as long as a specified condition is true. The syntax for a do-while loop is as follows:
// do
// {
// Code to be executed
// } while (condition);
// The do-while loop first executes the block of code, and then evaluates the condition. If the condition is true, the loop continues to execute. If the condition is false, the loop terminates. This means that the code inside a do-while loop will always be executed at least once, even if the condition is false from the beginning. It is important to ensure that the condition eventually becomes false to avoid creating an infinite loop.
