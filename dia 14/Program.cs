using System;
using dia_14.classes;

namespace dia_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2,5));
            Console.WriteLine("Digite Um valor");
            conversor.valorUsuario=float.Parse(Console.ReadLine());
            Console.WriteLine(conversor.ConverterDolarParaReal());
            Console.WriteLine(conversor.ConverterRealParaDolar());
            Console.WriteLine(conversor.ConverterEuroParaReal());
            Console.WriteLine(conversor.ConverterRealParaEuro());
        }
    }
}
