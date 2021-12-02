using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tLütfen Basamaklarına ayırmak istediğiniz sayıyı giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine()); Console.Clear(); Console.WriteLine("Sayı:"+s1+"\n");

            int bin = s1 / 1000; Console.WriteLine("1000 *:" + bin); s1 = s1 - (bin * 1000);
            int yuz = s1 / 100 ; Console.WriteLine("100 * :" + yuz); s1 = s1 - (yuz * 100 );
            int on  = s1 / 10  ; Console.WriteLine("10 *  :" + on ); s1 = s1 - (on  * 10  );
            int bir = s1       ; Console.WriteLine("1 *   :" + bir);
            Console.ReadLine();
        }
    }
}
