using System;

public class DatatypeConversion
{
    public static void Conversion()
    {
        // implicit conversion
        // What is implicit conversion? Implicit conversion, also known as automatic conversion, is the process of converting a value from one data type to another data type automatically by the compiler. It occurs when there is no risk of data loss and the conversion is safe. In implicit conversion, the compiler handles the conversion without requiring any explicit instructions from the programmer.
        int num1 = 10;
        double num2 = num1; // Implicit conversion from int to double
        Console.WriteLine(num2); // Output: 10.0


        // Explicit conversion
        // What is explicit conversion? Explicit conversion, also known as type casting, is the process of converting a value from one data type to another data type explicitly by the programmer. It is done when there is a possibility of data loss or when the conversion is not automatically handled by the compiler. In explicit conversion, the programmer must specify the target data type using a cast operator.
        double num3 = 9.99;
        int num4 = (int)num3; // Explicit conversion from double to int 
        Console.WriteLine(num4); // Output: 9

        // Explicit conversion using Convert class
        string str = "123";
        int num5 = Convert.ToInt32(str); // Explicit conversion from string to int using Convert class  
        Console.WriteLine(num5);

        // Parse()
        string str2 = "456";
        int num6 = int.Parse(str2); // Explicit conversion from string to int using Parse method
        Console.WriteLine(num6);

        // tryParse()
        string str3 = "789";
        bool isConversionSuccessful = int.TryParse(str3, out int num7); // Explicit conversion from string to int using TryParse method
        if (isConversionSuccessful)
        {
            Console.WriteLine(num7); // Output: 789
        }
        else
        {
            Console.WriteLine("Conversion failed.");
        }
        // How tryParse() works? The TryParse() method is a static method that attempts to convert a string representation of a number to its numeric equivalent. It takes two parameters: the string to be converted and an output parameter that will hold the converted value if the conversion is successful. The method returns a boolean value indicating whether the conversion was successful or not. If the conversion is successful, the output parameter will contain the converted value; otherwise, it will be set to the default value of the target data type (e.g., 0 for int).
    }
}
