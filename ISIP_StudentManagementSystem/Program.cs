using System;
using System.Collections.Generic;

List<Student> students = new List<Student>();

while (true)
{
    Console.WriteLine("\n==== STUDENT SYSTEM ====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.WriteLine("========================");
    Console.Write("Choose an option: ");

    string opt = Console.ReadLine();

    if (opt == "1")
    {
        Console.Write("\nEnter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        int grade1 = int.Parse(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        int grade2 = int.Parse(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        int grade3 = int.Parse(Console.ReadLine());

        Student student = new Student(name, grade1, grade2, grade3);

        students.Add(student);

        Console.WriteLine("Student added successfully!");
    }

    else if (opt == "2")
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            Console.WriteLine("\n==== STUDENT LIST ====");

            foreach (Student student in students)
            {
                Console.WriteLine($"\nName: {student.Name}");
                Console.WriteLine($"Grades: {student.Grade1}, {student.Grade2}, {student.Grade3}");
                Console.WriteLine($"Average: {student.GetAverage():F2}");
            }
        }
    }

    else if (opt == "3")
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            double totalAverage = 0;

            foreach (Student student in students)
            {
                totalAverage += student.GetAverage();
            }

            double classAverage = totalAverage / students.Count;

            Console.WriteLine("\n==== CLASS AVERAGE ====");
            Console.WriteLine($"Overall Average Grade: {classAverage:F2}");
        }
    }

    else if (opt == "4")
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            Student topStudent = students[0];
            int highestGrade = topStudent.GetHighestGrade();

            foreach (Student student in students)
            {
                if (student.GetHighestGrade() > highestGrade)
                {
                    highestGrade = student.GetHighestGrade();
                    topStudent = student;
                }
            }

            Console.WriteLine("\n==== HIGHEST GRADE ====");
            Console.WriteLine($"Top Student: {topStudent.Name}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
        }
    }

    else if (opt == "5")
    {
        Console.WriteLine("\nExiting program...");
        Console.WriteLine("Goodbye!");
        break;
    }

    else
    {
        Console.WriteLine("\nInvalid input! Please choose 1-5 only.");
    }
