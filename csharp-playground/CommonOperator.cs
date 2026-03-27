using System;
using System.Runtime.InteropServices;


public class CommonOperator{
    public static void Operators()
    {
        // Assignment operator
        int i = 10;

        // Arithmatcic operators
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine(num1 + num2); // Addition
        Console.WriteLine(num1 - num2); // Subtraction
        Console.WriteLine(num1 * num2); // Multiplication
        Console.WriteLine(num1 / num2); // Division
        Console.WriteLine(num1 % num2); // Modulus

        // Comparison operators
        int B = 10;
        int A = 20;
        Console.WriteLine(A > B); // Greater than
        Console.WriteLine(A < B); // Less than
        Console.WriteLine(A >= B); // Greater than or equal to
        Console.WriteLine(A <= B); // Less than or equal to
        Console.WriteLine(A == B); // Equal to
        Console.WriteLine(A != B); // Not equal to

        // Conditional operators
        bool condition1 = true;
        bool condition2 = false;
        Console.WriteLine(condition1 && condition2); // Logical AND
        Console.WriteLine(condition1 || condition2); // Logical OR
        Console.WriteLine(!condition1); // Logical NOT

        // Ternary operator
        int age = 18;
        string result = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine(result);

        // Null-coalescing operator
        string name = null;
        string displayName = name ?? "Guest";
        Console.WriteLine(displayName);


        // With null-coalescing operator

        int? TicketOnSale = null;
        int AvailableTickets= TicketOnSale ?? 100; // If TicketOnSale is null, use 100 as the default value
        Console.WriteLine("Available Ticket : ",AvailableTickets);

        // Without null-coalescing operator
        int? TicketOnSale2 = null;
        int AvailableTickets2;
        if (TicketOnSale2.HasValue)// Check if TicketOnSale2 has a value , Has Value Means that it is not null, we can access the value using the Value property
        { 
            AvailableTickets2 = TicketOnSale2.Value;// If TicketOnSale2 is not null, use its value as the available tickets why not directly assign TicketOnSale2 to AvailableTickets2 because TicketOnSale2 is a nullable int (int?) and AvailableTickets2 is a regular int, so we need to access the value of TicketOnSale2 using the Value property AvailableTickets2 = TicketOnSale2; why .value because AvailableTickets2 is a regular int and TicketOnSale2 is a nullable int (int?), we need to access the value of TicketOnSale2 using the Value property to assign it to AvailableTickets2
        }
        else
        {
            AvailableTickets2 =0; // Default value if TicketOnSale2 is null
        }
    }
}

