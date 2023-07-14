using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            //Print the student scored
            for(int i = 0; i< studentScores.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}\' scores: ");
                for(int j = 0; j < studentScores[i].Length; j++) 
                {
                    Console.WriteLine(studentScores[i][j]+ "\t" );
                }
                Console.WriteLine("\n");

            }
            
            //Average of the score for each student
            for(int i = 0; i<studentScores.Length; i++)
            {
                int sum = 0;
                for(int j= 0; j< studentScores[i].Length;j++) 
                { 
                    sum += studentScores[i][j]; 
                }

                int average = sum / studentScores[i].Length;
                Console.WriteLine($"Students Average score {i + 1} is {average}");
                
            }

            //Average Scores for all student combined
            int totalSum = 0;
            int totalCount = 0;

            for(int i = 0; i < studentScores.Length; i++)
            {
                for(int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;

                }
                
            }
            int totalAverage = totalSum / totalCount;
            Console.WriteLine($"\nAverage for all Students Combined {totalAverage}");

            Console.ReadLine();

            




        }
    }
}
