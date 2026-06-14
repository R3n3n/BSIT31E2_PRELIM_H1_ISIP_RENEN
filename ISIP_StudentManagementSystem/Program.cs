using System.ComponentModel.Design;
using System;

List<string> studNames = new List<string>();
List<int> studGrade1 = new List<int>();
List<int> studGrade2 = new List<int>();
List<int> studGrade3 = new List<int>();

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
        string studName = Console.ReadLine();
        studNames.Add(studName);
        Console.Write("Enter grade 1: ");
        int firstGrade = int.Parse(Console.ReadLine());
        studGrade1.Add(firstGrade);
        Console.Write("Enter grade 2: ");
        int secondGrade = int.Parse(Console.ReadLine());
        studGrade2.Add(secondGrade);
        Console.Write("Enter grade 3: ");
        int thirdGrade = int.Parse(Console.ReadLine());
        studGrade3.Add(thirdGrade);
        Console.WriteLine("Student added successfully! ");
    }

    else if (opt == "2")
    {
        if (studNames.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            for (int i = 0; i < studNames.Count; i++)
            {
                double average = (studGrade1[i] + studGrade2[i] + studGrade3[i]) / 3.00;
                Console.WriteLine($"\nName: {studNames[i]}");
                Console.WriteLine($"Grades: {studGrade1[i]}, {studGrade2[i]}, {studGrade3[i]}");
                Console.WriteLine($"Average: {average:F2}");

            }

        }

    }

    else if (opt == "3")
    {
        if (studNames.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            double totalAverage = 0;

            for (int i = 0; i < studNames.Count; i++)
            {
                double studAverage = (studGrade1[i] + studGrade2[i] + studGrade3[i]) / 3.00;
                totalAverage += studAverage;
            }
            double classAverage = totalAverage / studNames.Count;

            Console.WriteLine("\n==== CLASS AVERAGE ====");
            Console.WriteLine($"Overall Average Grade: {classAverage:F2}");
        }
    }

    else if (opt == "4")
    {
        if (studNames.Count == 0)
        {
            Console.WriteLine("No students found!");
        }
        else
        {
            string topStudent = "";
            int highestGrade = -1;

            for (int i = 0; i < studNames.Count; i++)
            {
                int highestStudent = Math.Max(studGrade1[i], Math.Max(studGrade2[i], studGrade3[i]));

                if (highestStudent > highestGrade)
                {
                    highestGrade = highestStudent;
                    topStudent = studNames[i];
                }
            }
            Console.WriteLine("\n==== HIGHEST GRADE ====");
            Console.WriteLine($"Top Student: {topStudent}");
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
        Console.WriteLine("\nInvalid Input! Please input numbers from 1-5 only.");
    }
}