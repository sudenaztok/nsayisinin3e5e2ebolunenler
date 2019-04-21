using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç sayı gireceksiniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int  btoplam = 0, ctoplam = 0, ktoplam = 0, b = 0, c = 0, k = 0;
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine("sayıyı gir");
                int s = Convert.ToInt32(Console.ReadLine());
                if (s%5==0)
                {
                    b = b + 1;
                    btoplam = btoplam + s;

                }
                if (s % 3 == 0)
                {
                    c = c + 1;
                    ctoplam = ctoplam + s;

                }
                if (s % 2 == 0)
                {
                    k = k + 1;
                    ktoplam = ktoplam + s;

                }


            }
            Console.WriteLine("beşe bölünebilen sayı adedi " + b);
            Console.WriteLine( "üçe bölünebilen sayı adedi " + c );
            Console.WriteLine( "ikiye bölünebilen sayı adedi " + k);
            Console.WriteLine("beşe bölünebilen sayıların toplamı " + btoplam);
            Console.WriteLine( "üçe bölünebilen sayıların toplamı " + ctoplam);
            Console.WriteLine( "ikiye bölünebilen sayıların toplamı " + ktoplam);
            Console.ReadLine();
            

        }
    }
}
