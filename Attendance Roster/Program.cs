/*This program will create an attendance roster for all the students in this C# Course*/

using System;

namespace Students
{

    class Roster
    {
        public static void Main(string[] args)
        {

            string[] students = { "Mark", "Christopher", "Christina", "John", "Avery", "Joe", "Phillip" };


            Console.WriteLine("Please print out a list of students in this C# Course");
            Console.ReadKey();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

    }
}