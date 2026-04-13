using System;
using System.IO;

namespace Assignment6
{
    class FileReadWrite
    {
        static void Main()
        {
            // File path - make sure the folder exists
            string filePath = @"C:\Users\deepakl\Dotnet Assignment\Assignment6\Assignment6\Deepak_text_file.txt";

            // Array of strings to write to the file
            string[] linesToWrite = {
                "Hello I am Deepak",

                "Assignment6 Csharp file read and ",

                "This is a sample text file in C#."
                
            };

            StreamWriter writer = new StreamWriter(filePath);
            foreach (string line in linesToWrite)
            {
                writer.WriteLine(line);
            }
            writer.Close(); // Always close the writer
            Console.WriteLine("Data written to file successfully.\n");

            // Read from the file
            StreamReader reader = new StreamReader(filePath);
            Console.WriteLine("Reading from file:\n");
            string lineRead = reader.ReadLine();
            while (lineRead != null)
            {
                Console.WriteLine(lineRead);
                lineRead = reader.ReadLine();
            }
            reader.Close(); // Always close the reader

            Console.WriteLine("\nProgram executed successfully. Press any key to exit.");
            Console.ReadKey();
        }
    }
}