using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vN, vi, vj;
            Console.Write("Введите число N=");
            vN = Convert.ToInt16(Console.ReadLine());
            int[,] arrey = new int[vN,vN];
            for (int i = 0; i < vN; i++)
            {
                for (int j = 0; j < vN; j++)
                {
                    vi = i / 2;
                    vj = j / 2;
                    if ((2 * vi - i) == (2 * vj - j)) arrey[i, j] = 1;
                    else arrey[i, j] = 0;
                    Console.Write("{0} ", arrey[i, j]);
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
