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
        public static int cvaltozo; //csak static

        static void Main(string[] args)
        {
            var aValtozo = 20;
            int bValtozo = 40;
            cvaltozo = 40;

            var tomb = new int[6];
            int[] tomb2 = new int[6] { 18, 7, 4, 29, 76, 34 };

            tomb[0] = 19;
            tomb[1] = 6;
            tomb[2] = 3;
            tomb[3] = 28;
            tomb[4] = 75;
            tomb[5] = 33;


            // egyszerű rendezés

            tombKiir(tomb);

            var temp = 0;
            for (int i = 0; i < tomb.Count(); i++)
            {

                Console.WriteLine(bValtozo);
                //Debug.WriteLine(tomb[i]);
                for (int j = i + 1; j < tomb.Count(); j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        temp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = temp;
                    }
                }


            }
            tombKiir(tomb);
            Console.ReadKey();




        }

        private static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Count(); i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
}
