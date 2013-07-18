/* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash. Implement collision detection and scoring system. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

    struct Rock //Define Rocks
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public char c;
    }
    
    class FallingRocks
    {
        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray) // Defines the PrintOnPosition method,
        {                                                                                         // used for drawing the board.
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color; 
            Console.Write(c);
        }
        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray) //Defines the PrintStringOnPosition,
        {                                                                                                  //used for keeping the score and lives.   
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void Main() // Defines the playground and variables used for speed of the game, maximum rocks and live counter.
        {
            int speed = 100;
            int rocksMax = 40;
            int playfieldWith = 27;
            int livesCount = 5;
            int score = 0;
            Console.BufferHeight = Console.WindowHeight=30;
            Console.BufferWidth = Console.WindowWidth=40;
            Rock dwarf= new Rock();  //Creates the player - dwarf.
            dwarf.y = Console.WindowHeight - 1;
            dwarf.x = 13;
            dwarf.color = ConsoleColor.White;
            dwarf.c = 'O';
            Random randomGenerator = new Random(); 
            List<Rock> rocks = new List<Rock>();
            while (true)
            {
                bool hitted = false;
                {
                    Rock newRock = new Rock();   //Creates the rocks with random position, char and color.
                    char[] symbol = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    int i = randomGenerator.Next(0, symbol.Length);
                    newRock.color = (ConsoleColor)randomGenerator.Next(9, 15);
                    newRock.x = randomGenerator.Next(0, playfieldWith);
                    newRock.y = 0;
                    newRock.c = symbol[i];
                    rocks.Add(newRock);
                }
                if (Console.KeyAvailable)  //Checks the player interaction.
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.x - 1 >= 0)
                        {
                            dwarf.x --;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.x + 1 < playfieldWith)
                        {
                            dwarf.x++;
                        }
                    }
                }
                List<Rock> newList = new List<Rock>();
                for (int y = 0; y < rocks.Count && y<=rocksMax; y++) //Moves the rocks downward.
                {
                    Rock oldRock = rocks[y];
                    Rock newRock = new Rock();
                    newRock.x = oldRock.x;
                    newRock.y = oldRock.y + 1;
                    newRock.c = oldRock.c;
                    newRock.color = oldRock.color;

                    if (newRock.y == dwarf.y && newRock.x == dwarf.x) // Check if the dwarf is hitted and removes one life from the counter.
                    {                                                 // If the counter reaches zero the "Game over" message appears.
                        livesCount--;
                        hitted = true;

                        if (livesCount <= 0)
                        {
                            PrintStringOnPosition(4, 10,"GAME OVER!", ConsoleColor.Red);
                            PrintStringOnPosition(4, 12, "Press enter key to exit...", ConsoleColor.Green);
                            Console.ReadLine();
                            return;
                        }
                    }

                    if (newRock.y < Console.WindowHeight) // Checks the position of the rocks and removes them when they reach ground zero.
                    {
                        newList.Add(newRock);
                    }
                    else 
                    {
                        score++;   //Adds 1 point of score on each rock passed.
                        if (score % 100 == 0)
                        {
                            livesCount++; //Adds 1 live on each 100 rocks.
                            rocksMax += 20; // Rises the maximum rocks on each 100 rocks.
                        }
                    }
                    speed++; // Rises the speed if it is below 400 (Speed 450 = Thread.Sleep(150)).
                    if (speed >= 450)
                     {
                        speed=450;
                     } 
                }
                rocks = newList;
                Console.Clear();

                if (hitted) // Check if the dwarf is hitted and prints 'X' on the spot if hitted.
                {
                    rocks.Clear();
                    speed = 100;
                    PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                    rocksMax = 40;
                    Console.Beep();
                }
                else          //Redraws the dwarf if not hitted.
                {
                    if (dwarf.x != 0 && dwarf.x != playfieldWith - 1)
                    {
                        PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
                        PrintOnPosition(dwarf.x - 1, dwarf.y, '(', dwarf.color);
                        PrintOnPosition(dwarf.x + 1, dwarf.y, ')', dwarf.color);
                    }
                    else if (dwarf.x == 0)
                    {
                        PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
                        PrintOnPosition(dwarf.x + 1, dwarf.y, ')', dwarf.color);
                    }
                    else if (dwarf.x == playfieldWith - 1)
                    {
                        PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
                        PrintOnPosition(dwarf.x - 1, dwarf.y, '(', dwarf.color);
                    }

                }

                foreach (Rock rock in rocks) //Redraws rocks.
                {
                    PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
                }

                for (int i = 0; i < Console.WindowHeight; i++) // Draws a line between the field and the score
                {
                    PrintOnPosition(playfieldWith, i, '|', ConsoleColor.White);
                }
                PrintStringOnPosition(29, 0, "Lives: " + livesCount); //Score, lives, speed and max rocks info.
                PrintStringOnPosition(29, 4, "Score: " + score);
                PrintStringOnPosition(29, 6, "Speed: " + speed);
                PrintStringOnPosition(29, 8, "Rocks: " + rocksMax);
                Thread.Sleep(600-speed);
            }            
        }
    }