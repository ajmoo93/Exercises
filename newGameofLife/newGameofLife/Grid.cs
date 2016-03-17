using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGameofLife
{
    class Grid
    {
        public bool[,] newgeneration;
        public bool[,] Generation { get { return newgeneration; } }

        int width;
        int heigth;

        public Grid(int width, int heigth)
        {

            //newgeneration bool[newrow, column];
            Random myRandom = new Random();
            this.width = width;
            this.heigth = heigth;
            newgeneration = new bool[width, heigth];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    var nextValue = myRandom.Next(10);
                    if (nextValue < 5)
                        newgeneration[x, y] = true;
                    else
                        newgeneration[x, y] = false;
                }
            }
        }
        public void GoToNextGeneration()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    var myneighbours = CountNeighbour(x, y);
                    if (myneighbours < 2)
                        newgeneration[x, y] = false;
                    else if ((myneighbours == 2 || myneighbours == 3) && newgeneration[x, y] == true)
                        newgeneration[x, y] = true;
                    else if (myneighbours > 3)
                        newgeneration[x, y] = false;
                    else if (myneighbours == 3 && newgeneration[x, y] == false)
                        newgeneration[x, y] = true;
                }
            }
        }

        public void Draw()
        {
            //newgeneration[x, y];
            Console.Clear();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    if (newgeneration[x, y] == true)
                        Console.BackgroundColor = ConsoleColor.Green;
                    else
                        Console.BackgroundColor = ConsoleColor.Red;

                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
            }
        }
        

        public bool[,] GetGeneration()
        {
            var result = new bool[width, heigth];
                for (int y = 0; y < heigth; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    result[x, y] = newgeneration[x, y];
            }
        }
        return result;
            }

        public int CountNeighbour(int x, int y)
        {
            var result = 0;
            

            if (newgeneration[x - 1, y - 1] == true) result++;
            if (newgeneration[x, y - 1] == true) result++;
            if (newgeneration[x + 1, y - 1] == true) result++;

            if (newgeneration[x - 1, y] == true) result++;
            if (newgeneration[x, y] == true) result++;
            if (newgeneration[x + 1, y] == true) result++;


            if (newgeneration[x - 1, y + 1] == true) result++;
            if (newgeneration[x, y + 1] == true) result++;
            if (newgeneration[x + 1, y + 1] == true) result++;


            {

                return result;

            }
        }
       
            }
        }

       



            //for ( int x2 = 0; x2<width; x2++)
            //{
            //    for (int y2 = 0; y2<heigth; y2++)
            //    {
