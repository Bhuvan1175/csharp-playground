using System;

public class SwitchStatement
{
    public static void Switch(string[] args)
    {
        string choice;

        do
        {
            Console.Write("Enter day number (1-7): ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day of the week");
                    break;
            }

            Console.Write("Do you want to continue? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("Program ended.");
    }
}

// What is Switch Statement in C#?
// A switch statement in C# is a control flow statement that allows you to execute different blocks of code based on the value of a variable or expression. It provides a more concise and readable way to handle multiple conditions compared to using multiple if-else statements. The switch statement evaluates the expression and compares it against a list of case labels. If a match is found, the corresponding block of code is executed. If no match is found, the default case (if provided) is executed.
// What Above Code Does?
// The above code is a simple console application that demonstrates the use of a switch statement. It prompts the user to enter a day number (1-7) and then uses a switch statement to determine which day of the week corresponds to that number. The program continues to prompt the user until they choose to exit by entering "no". If the user enters an invalid day number, it will display an error message.