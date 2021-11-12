using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2DTextMap
{
    class Program
    {
        static int xLength = 29;
        static int yLength = 11;

        static string verticalWall = "|";
        static string horizontalWall = "-";
        static string corners = "+";
        static string[,] map = new string[,] // dimensions defined by following data:
    {
        {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","^","^","^"},
        {"'","'","'","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","~","~","~","^","^","^"},
        {"'","'","'","'","'","*","*","'","'","'","'","'","'","'","'","'","'","'","*","*","*","'","~","~","~","'","'","'","'","'"},
        {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","=","=","=","=","=","=","=","=","=","=","=","=","=","="},
        {"'","'","'","~","~","~","~","'","'","'","'","'","'","'","'","'","=","'","*","*","*","'","'","'","'","'","'","'","'","'"},
        {"=","=","=","=","=","=","=","=","=","=","=","=","=","=","=","=","=","'","'","'","'","'","'","'","'","'","'","'","'","'"},
        {"'","'","'","~","~","~","~","'","'","'","=","*","*","*","*","*","=","'","'","'","'","'","^","^","'","'","'","'","'","'"},
        {"'","'","'","~","~","~","~","'","'","'","=","*","*","*","'","*","=","*","'","'","'","^","^","^","^","'","'","'","'","'"},
        {"'","'","'","~","~","~","~","'","'","'","=","=","=","=","=","=","=","'","'","'","'","'","'","^","^","^","^","'","'","'"},
        {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
        {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
        {"'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'"},
    };
        // map legend:
        // ^ = mountain
        // " = grass
        // ~ = water
        // * = trees
        // = = road
        

        static void Main(string[] args)
        {
            Console.WriteLine("TextMap");
            DisplayMap();
            DisplayMap(3);
            Console.ReadKey(true);
        }
        static void DisplayMap()
        {
            for (int y = 0; y <= yLength; y++)
            {
                for (int x = 0; x <= xLength; x++)
                {
                    Console.Write(map[y, x].ToString());

                }
                Console.WriteLine();
            }
        }
        static void DisplayMap(int scale)
        {
            //Top part of border
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(corners);
            for (int x = 0; x <= xLength * scale + scale - 1; x++)
            {
                Console.Write(horizontalWall);
            }
            Console.Write(corners);
            Console.WriteLine();
            //Main map loop 
            for (int y = 0; y <= yLength; y++) 
            {
                for (int i = 1; i <= scale; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(verticalWall);
                    for (int x = 0; x <= xLength; x++)
                    {
                        for (int j = 1; j <= scale; j++)
                        {
                            Console.Write(map[y, x].ToString());
                            if (map[y, x] == "~") { Console.ForegroundColor = ConsoleColor.White; }
                            if (map[y, x] == "~") { Console.BackgroundColor = ConsoleColor.Blue; }
                            if (map[y, x] == "^") { Console.ForegroundColor = ConsoleColor.White; }
                            if (map[y, x] == "^") { Console.BackgroundColor = ConsoleColor.Gray; }
                            if (map[y, x] == "'") { Console.ForegroundColor = ConsoleColor.Green; }
                            if (map[y, x] == "'") { Console.BackgroundColor = ConsoleColor.DarkGreen; }
                            if (map[y, x] == "*") { Console.ForegroundColor = ConsoleColor.Yellow; }
                            if (map[y, x] == "*") { Console.BackgroundColor = ConsoleColor.DarkYellow; }
                            if (map[y, x] == "=") { Console.ForegroundColor = ConsoleColor.Red; }
                            if (map[y, x] == "=") { Console.BackgroundColor = ConsoleColor.DarkRed; }

                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(verticalWall);
                    Console.WriteLine();
                }
            }
            //Bottom part of border
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(corners);
            for (int x = 0; x <= xLength * scale + scale - 1; x++)
            {
                Console.Write(horizontalWall);
            }
            Console.Write(corners);
            Console.WriteLine();
        }
    }
}
