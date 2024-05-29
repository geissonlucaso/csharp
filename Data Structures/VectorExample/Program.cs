/*
    Create a program that reads the grade and name of n students and 
    displays on the screen the names of those who were above the group 
    average, with n being an integer read from the keyboard.
*/

using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Type the number of students: ");
        int number = int.Parse(Console.ReadLine());
        Student[] students = new Student[number];

        double avg = 0.0;

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("Type the name: ");
            string name = Console.ReadLine();
            Console.Write("Type the grade: ");
            int grade = int.Parse(Console.ReadLine());

            avg += grade;
            students[i] = new Student(name, grade);
        }

        avg = avg/number;

        for (int i = 0; i < students.Length; i++)
        {
            if(students[i].Grade > avg)
            {
                Console.WriteLine(students[i]);
            }
        }

        //Console.WriteLine($"Average: {avg}\n");
    }
}