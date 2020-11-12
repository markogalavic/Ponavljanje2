using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavicPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite stringove");
            string znakovi = Console.ReadLine();

            Console.WriteLine(znakovi.Replace(" ","_"));
            Console.ReadKey();
        }
    }
}
