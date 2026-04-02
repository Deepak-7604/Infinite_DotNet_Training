using System;

namespace Code_Challenge1
{
    public struct DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;
    }

    public struct EmployeeNested
    {
        public string Name;
        public DateOfBirth Dob; 
    }

    class NestedStructEmployeeProgram
    {
        static void Main()
        {
            EmployeeNested[] emp = new EmployeeNested[2];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Name of the employee: ");
                emp[i].Name = Console.ReadLine();

                Console.Write("Enter day of the birth: ");
                emp[i].Dob.Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter month of the birth: ");
                emp[i].Dob.Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter year for the birth: ");
                emp[i].Dob.Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\nEmployee Details:");
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Name: " + emp[i].Name);
                Console.WriteLine("DOB: " + emp[i].Dob.Day + "/" +
                                           emp[i].Dob.Month + "/" +
                                           emp[i].Dob.Year);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}