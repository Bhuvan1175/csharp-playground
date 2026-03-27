using System;
public class ConditionalStatement
{
       public static void CondState(string[] args)
    {
        int number = 10;
        // if statement
        if (number > 5)
        {
            Console.WriteLine("Number is greater than 5");
        }
        // if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
        // if-else-if statement
        if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Number is negative");
        }
        else
        {
            Console.WriteLine("Number is zero");
        }
    }
}
// What is Conditional Statement in C#?
// A conditional statement in C# is a programming construct that allows you to execute different blocks of code based on certain conditions. It enables you to make decisions in your code and control the flow of execution. The most common conditional statements in C# are the if statement, if-else statement, and if-else-if statement. These statements evaluate a condition and execute the corresponding block of code if the condition is true, or skip it if the condition is false.


