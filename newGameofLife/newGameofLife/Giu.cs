using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGameofLife
{
    class Giu
    {
       public void Rit (bool[,] Generation)
        {
            var width = Generation.GetLength(1);
            var heigth = Generation.GetLength(2);

            for (int y = 0; y < heigth; y++)
            {
                for(int x = 0; x < width; x++)

                {
                    
                    Console.Write(" ");
                    var ggColor = Generation[x, y] ? ConsoleColor.Blue : ConsoleColor.Cyan;



                }
                
            }
            
        }
    }
}
