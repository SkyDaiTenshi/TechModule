using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter1 = 1;
            var countern = n;
            var countern2 = n*2;
            //1vi red

            Console.Write("##");
            Console.Write(new string ('.',n*2));
            Console.Write("##");
            Console.Write(new string('.', n * 2));
            Console.Write("##");
            Console.WriteLine();
            //chashkata na cveteto do predi centyra i

            for (int i=1; i<n; i++)

            {
                Console.Write('#');
                Console.Write(new string('~', i));
                Console.Write('#');
                Console.Write(new string('.', (n*2)-(i*2)));
                Console.Write('#');
                Console.Write(new string('.', (i * 2)));
                Console.Write('#');
                Console.Write(new string('.', (n * 2) - (i * 2)));
                Console.Write('#');
                Console.Write(new string('~', i));
                Console.Write('#');
                Console.WriteLine();
            }

            // ot centyra na dolu

            for (int i=1; i<=n+1; i++)
            {
                Console.Write(new string('.', counter1));
                Console.Write('#');
                Console.Write(new string('~', countern));
                Console.Write('#');
                Console.Write(new string('.', countern2));
                countern2 -= 2;
                Console.Write('#');
                Console.Write(new string('~', countern));
                countern -= 1;
                Console.Write('#');
                Console.Write(new string('.', counter1));
                counter1 += 2;
                Console.WriteLine();
            }

            for (int i=1; i<=n; i++)
            {
                Console.Write(new string('.', ((4*n+6)/2)-1));
                Console.Write("##");
                Console.Write(new string('.', ((4 * n + 6) / 2) - 1));
                Console.WriteLine();

            }
        }
    }
}

