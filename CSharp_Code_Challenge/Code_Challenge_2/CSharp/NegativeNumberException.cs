using System;

namespace Code_Challenge_2
{
   
    class NegativeNumberCustomException : Exception
    {
        public NegativeNumberCustomException(string message) : base(message)
        {
        }
    }

    class NegativeNumberException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Negative integer check =====\n");

            try
            {
                
                Console.Write("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());

               
                CheckNumber(num);

               
                Console.WriteLine("\nSuccess! Entered number: " + num);
                Console.WriteLine("This is a positive number or zero.");
            }
            catch (NegativeNumberCustomException ex) 
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram executed successfully.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }

        // Method to check negative numbers
        static void CheckNumber(int num)
        {
            if (num < 0)
            {
                // Throw custom exception if number is negative
                throw new NegativeNumberCustomException("Number can't be negative. Please enter zero or a positive number.");
            }
        }
    }
}