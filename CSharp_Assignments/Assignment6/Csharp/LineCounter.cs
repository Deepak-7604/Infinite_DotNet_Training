using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class LineCounter
    {
        public static void Main()
        {
            string directoryPath = @"C:\Users\deepakl\Dotnet Assignment";
            string filePath = Path.Combine(directoryPath, "sample.txt");

            // Count and display the number of lines in the file
            CountLinesInFile(filePath);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

     
        public static void CountLinesInFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Method 1: Using File.ReadAllLines
                    string[] lines = File.ReadAllLines(filePath);
                    int lineCount = lines.Length;

                    Console.WriteLine($"File: {filePath}");
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"Total number of lines: {lineCount}");
                    Console.WriteLine(new string('-', 40));

                    // Display file contents with line numbers
                    Console.WriteLine("\nFile Contents:");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine($"Line {i + 1}: {lines[i]}");
                    }
                }
                else
                {
                    Console.WriteLine($"File '{filePath}' does not exist.");
                    Console.WriteLine("Please ensure the file exists in the application directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error counting lines in file: {ex.Message}");
            }
        }

  
        public static void CountLinesUsingStreamReader(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    int lineCount = 0;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (reader.ReadLine() != null)
                        {
                            lineCount++;
                        }
                    }

                    Console.WriteLine($"File: {filePath}");
                    Console.WriteLine($"Total number of lines: {lineCount}");
                }
                else
                {
                    Console.WriteLine($"File '{filePath}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error counting lines in file: {ex.Message}");
            }
        }
    }
}
