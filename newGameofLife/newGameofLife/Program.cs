using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGameofLife
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Grid NGrid = new Grid(40, 20);
            var guil = new Guid();

            while (true)
            {
                NGrid.Draw();
                //guil.Rit(NGrid.Generation);
                Console.ReadKey();
            }

        }
    }
}
