using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hubtest_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var aValtozo = 20;
            int bValtozo = 40;

            var tomb= new int[6];
            int[] tomb2 = new int[6] {18,7,4,29,76,34};

            tomb[0] = 19;
            tomb[1] = 6;
            tomb[2] = 3;
            tomb[3] = 28;
            tomb[4] = 75;
            tomb[5] = 33;

            Console.WriteLine("Hello Git!");
            Console.ReadKey();
            Console.WriteLine("Hello Git again!");
            Console.ReadKey();
            Console.WriteLine("Hello Gitter !{0},{1}",aValtozo,bValtozo);
            Console.ReadKey();
            // egyszerű rendezés

            for(int i=0; i<tomb.Count();i++)
            {
                Debug.WriteLine(tomb[i]);
            }
        



        }
    }
}
