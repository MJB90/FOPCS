using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseG
{
    class q3b
    {
        static void OutputStudentData(double[,] studentMarks,int numStudents,int numSubjects)
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
                Console.Write(total_perStudent[i] + "\t" + total_perStudent[i] / numSubjects);
                Console.WriteLine();
            }
            Console.WriteLine("Average per Subject :");
            for (j = 0; j < numSubjects; j++)
            {
                Console.Write(total_perSubject[j] / numStudents + "\t");
            }
            Console.WriteLine();

        }
        static void Main()
        {
            int i,j,numStudents, numSubjects;
            double[,] studentMarks;
            string marks;
            string[] submarks;

            Console.Write("Enter the number of students : ");
            numStudents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of subjects : ");
            numSubjects = Convert.ToInt32(Console.ReadLine());

            studentMarks = new double[numStudents, numSubjects];

            for (i = 0; i < numStudents; i++)
            {
                Console.Write("Enter marks for student {0} separated by comma: " , i + 1);
                marks = Console.ReadLine();
                submarks = marks.Split(',');

                for (j = 0; j < numSubjects; j++)
                {
                    studentMarks[i, j] = Convert.ToDouble(submarks[j]);
                }
            }

            OutputStudentData(studentMarks, numStudents, numSubjects);
        }
    }
}
