using System;
public class ForLoop
{
       public static void For(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }
    }
}
// Notes For For Loop in C#:
// A for loop in C# is a control flow statement that allows you to execute a block of code a specific number of times. The syntax for a for loop is as follows:
// for (initialization; condition; iteration)
// {
// Code to be executed
// }
// The for loop consists of three parts: initialization, condition, and iteration. The initialization is executed once at the beginning of the loop and is typically used to declare and initialize a loop variable. The condition is evaluated before each iteration, and if it evaluates to true, the code inside the loop is executed. After each iteration, the iteration statement is executed, which is usually used to update the loop variable. This process continues until the condition becomes false. For loops are commonly used when the number of iterations is known beforehand.
