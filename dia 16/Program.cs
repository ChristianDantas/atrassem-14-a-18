using System;
using System.Collections.Generic;
using dia_16.classes;

namespace dia_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<marca> Marcas= new List<marca>();
           Marcas.Add(new marca(30, "ford", 12000.50f));
           Marcas.Add(new marca(40, "chevrolet", 8000.50f));
           Marcas.Add(new marca(70, "ferrari", 1586000.50f));
           Marcas.Add(new marca(50, "mustang", 132453000.50f));

           marca _marcas= new marca();
           _marcas.ID=60;
            _marcas.Nome="mercedes";
             _marcas.Preco=567431000f;
             Marcas.Add(_marcas);
   
                 foreach (marca m in Marcas)
                  {
             Console.WriteLine($"{m.Nome}-R${m.Preco}");

                 }
            Marcas.RemoveAt(1);
            Console.WriteLine("\nRemovendo......\n");
               foreach (marca m in Marcas)
                  {
             Console.WriteLine($"{m.Nome}-R${m.Preco}");

                 }
                 Marcas.RemoveAll(x=>x.ID==50);

    }
 }
}
