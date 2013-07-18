//* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.


using System;

    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 20)
            {
                Console.WriteLine("Out of range!");
            }

            else
            {
                int[,] matrix = new int[n, n];
                int col = 0;
                int row = 0;
                string direction = "right";
                int maxRotation = n * n;


                for (int i = 1; i <= maxRotation; i++)
                {
                    if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        col--;
                        row++;
                    }

                    if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row--;
                        col--;
                    }
                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "up";
                        col++;
                        row--;
                    }
                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "right";
                        row++;
                        col++;
                    }
                    matrix[row, col] = i;
                    if (direction == "right")
                    {
                        col++;
                    }

                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                }

                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write("{0,4}", matrix[r, c]);
                    }
                    Console.WriteLine();
                }
            }
        }
    } 