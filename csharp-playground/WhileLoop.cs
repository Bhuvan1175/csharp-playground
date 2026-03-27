using System;
public class WhileLoop
{
    public static void While(string[] args)
    {
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine("Count: " + count);
            count++;
        }
    }
}

// Notes For While Loop in C#:
// A while loop in C# is a control flow statement that allows you to execute a block of code repeatedly as long as a specified condition is true. The syntax for a while loop is as follows:
// while (condition)
// {
// Code to be executed
// }
// The while loop evaluates the condition before executing the block of code. If the condition is true, the code inside the loop is executed, and then the condition is evaluated again. This process continues until the condition becomes false. If the condition is false from the beginning, the code inside the loop will not be executed at all. It is important to ensure that the condition eventually becomes false to avoid creating an infinite loop.
