using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpım_tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("çarpım tablosunu oluşturmak için bir sayı girşn: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"{sayi} * {i} = {sayi * i}");
            }

            Console.ReadLine();
        }
    }
}
