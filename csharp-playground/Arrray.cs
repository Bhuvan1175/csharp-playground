using System;
 

public class Arrray 
{
    public static void Array()
    {
        // What is an array? An array is a data structure that can hold a fixed number of values of the same type. It is used to store multiple values in a single variable, instead of declaring separate variables for each value. Arrays are indexed, meaning that each element in the array can be accessed using its index, which starts at 0.
        // Declaring and initializing an array
        int[] numbers = new int[5]; // Declaring an array of integers with a size of 5
        numbers[0] = 10; // Assigning values to the array elements
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        // Accessing array elements
        Console.WriteLine(numbers[0]); // Output: 10
        Console.WriteLine(numbers[1]); // Output: 20
        Console.WriteLine(numbers[2]); // Output: 30
        Console.WriteLine(numbers[3]); // Output: 40
        Console.WriteLine(numbers[4]); // Output: 50
        // Array initialization using an initializer list
        string[] fruits = new string[] { "Apple", "Banana", "Cherry" }; // Declaring and initializing an array of strings
        // Accessing array elements
        Console.WriteLine(fruits[0]); // Output: Apple
        Console.WriteLine(fruits[1]); // Output: Banana
        Console.WriteLine(fruits[2]); // Output: Cherry

        // Diiferent types of arrays
        // 1. Single-dimensional array
        int[] singleDimensionalArray = new int[3] { 1, 2, 3 };
        // 2. Multi-dimensional array
        int[,] multiDimensionalArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        // 3. Jagged array
        int[][] jaggedArray = new int[2][]; // Declaring a jagged array with 2 rows
        jaggedArray[0] = new int[] { 1, 2 }; // Initializing the first row with an array of size 2
        jaggedArray[1] = new int[] { 3, 4, 5 }; // Initializing the second row with an array of size 3


        // Difffent Way to declare and initialize an array
        // 1. Using the new keyword
        int[] array1 = new int[5]; // Declaring an array of integers with a size of 5
        // 2. Using an initializer list
        int[] array2 = new int[] { 1, 2, 3, 4, 5 }; // Declaring and initializing an array of integers using an initializer list
        // 3. Using implicit typing with var
        var array3 = new int[] { 10, 20, 30, 40, 50 }; // Declaring and initializing an array of integers using implicit typing with var
       

    }
}