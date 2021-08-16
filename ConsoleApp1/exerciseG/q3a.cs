using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseG
{
    class q3a
    {
        static void OutputStudentData(double[,] studentMarks, int numStudents, int numSubjects)
        {
            double[] total_perStudent = new double[numStudents], total_perSubject = new double[numSubjects];
            int i, j;

            //Calculate the total marks per student and the total marks per subject
            for (i = 0; i < numStudents; i++)
            {
                for (j = 0; j < numSubjects; j++)
                {
                    total_perStudent[i] += studentMarks[i, j];
                    total_perSubject[j] += studentMarks[i, j];
                }
            }

            //Print the data
            Console.WriteLine();
            for (j = 0; j < numSubjects; j++)
            {
                Console.Write("Subject {0}\t", j + 1);
            }
            Console.Write("Total\tAvg\n");
            for (i = 0; i < numStudents; i++)
            {
                for (j = 0; j < numSubjects; j++)
                {
                    Console.Write(studentMarks[i, j] + "\t\t");
                }
                Console.Write(total_perStudent[i] + "\t" + total_perStudent[i]/numSubjects);
                Console.WriteLine();
            }
            Console.WriteLine("Average per Subject :");
            for (j = 0; j < numSubjects; j++)
            {
                Console.Write( total_perSubject[j]/ numStudents + "\t");
            }
            Console.WriteLine();

        }
        static void Main()
        {
            int numStudents, numSubjects;

            numStudents = 12;
            numSubjects = 4;

            double[,] studentMarks = new double[,] { { 56, 84, 68, 29 },
                                                     { 94, 73, 31, 96 },
                                                     { 41, 63, 36, 90 },
                                                     { 99,  9, 18, 17 },
                                                     { 62,  3, 65, 75 },
                                                     { 40, 96, 53, 23 },
                                                     { 81, 15, 27, 30 },
                                                     { 21, 70,100, 22 },
                                                     { 88, 50, 13, 12 },
                                                     { 48, 54, 52, 78 },
                                                     { 64, 71, 67, 25 },
                                                     { 16, 93, 46, 72 }};

            OutputStudentData(studentMarks, numStudents, numSubjects);
        }
    }
}
