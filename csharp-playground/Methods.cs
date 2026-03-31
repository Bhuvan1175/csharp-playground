using System;

namespace CSharpPlayground
{
    class Methods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
                int result = Add(5, 3);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
// This code defines a simple C# program with a `Main` method that prints "Hello, World!" to the console and then calls an `Add` method to add two integers (5 and 3) together. The `Add` method takes two integer parameters and returns their sum.
// Static & Instance Methods: Static methods belong to the class and can be called without creating an instance of the class, while instance methods require an object of the class to be invoked. In this code, both `Main` and `Add` are static methods, meaning they can be called directly on the class without needing to create an instance of `Methods`.
// how to call a method: To call a method, you use the method name followed by parentheses. If the method requires parameters, you provide the arguments within the parentheses. For example, `Add(5, 3)` calls the `Add` method with the arguments 5 and 3, which will return their sum (8).
// How to Call Static Methods: Static methods can be called directly on the class without creating an instance. For example, you can call `Methods.Add(5, 3)` to invoke the `Add` method from the `Methods` class. In this code, since we are calling `Add` from within the same class, we can simply use `Add(5, 3)` without the class name.
// how to Call Instance Methods: To call an instance method, you first need to create an object of the class that contains the method. For example, if we had an instance method called `Subtract` in the `Methods` class, you would create an instance of the class and then call the method on that instance like this: