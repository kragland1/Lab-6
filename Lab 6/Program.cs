//Grading ID: R2226
// Program 2
// 03/ 10/ 2022
// CIS 199 - 02
// This program is trying to compute what a star prymaid will look like based off of for statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;
            // This for statement is used to make the first prymaid correctly
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(" ");// This is here to give space between the prymaids
            // This for statement is used to make the second prymaid upside down
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 10; star >= row; star--)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(" ");// space between the prymaid
            // this is a double nested for statement is to make the prymaid be built but backwards
            for (int row = MAX_ROWS; row >= 1; row--)
            {
                for (int space = 1; space <= (MAX_ROWS - row); space++)
                    Console.Write(" ");

                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine (" ");// Gives a space between the prymaids.
            // This for statement that is also  double nested and is to also make the prymaid get built backwards but also upside down.
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = 1; space <= (MAX_ROWS - row); space++)
                    Console.Write(" ");

                for (int star = 1; star <= row; star++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
