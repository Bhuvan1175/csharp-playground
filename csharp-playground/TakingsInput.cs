using System;


namespace csharp_playground
{
    public class TakingsInput
    {
        public  static void TakingInput()
        {
            Console.WriteLine("Please Enter Your First Name:");
            string Firstname=Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name:");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}",Firstname, Lastname);
        }
    }
}
