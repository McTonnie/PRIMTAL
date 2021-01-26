using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tets
{
    class Program
    {
        static void Main(string[] args)
        {



            
            int tal = (int)integertjek();
            bool truetjek = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1");

            for (double i = 2; i <= tal; i++)
            {
                for (double k = 2; k < i; k++)
                {
                    double primtjek = i / k;
                    int tempout;
                    truetjek = int.TryParse(primtjek.ToString(), out tempout);
                    if (truetjek == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                }

                if (truetjek == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }


        public static double integertjek()
        {


            int res = 0;
            bool truetjek = false;
            while (truetjek == false)
            {
                truetjek = Int32.TryParse(Console.ReadLine(), out res);
                if (truetjek == false)
                    Console.WriteLine("Du kan kun skrive heltal her prøv igen");

            }

            return res;
        }
    }
}


//truetjek = Int32.TryParse();
//if (truetjek == true)
//    Console.WriteLine("");