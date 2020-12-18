using System;
using adicional.classes;
namespace adicional
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarrinho combi= new ICarrinho();
            produto p1= new produto();
            
            p1.codigo= 102;
            p1.nome="GTA 5";
            p1.preco= 200;
            produto p2= new produto();
            p2.codigo= 103;
            p2.nome="Bully";
            p2.preco= 200;
            produto p3= new produto();
            p3.codigo= 104;
            p3.nome="Red Dead Redemption 2";
            p3.preco= 200;
            combi.cadastra(p1);

             combi.cadastra(p2);

              combi.cadastra(p3);

              combi.listar();

              Console.WriteLine("\n adicionando.......\n");
              combi.cadastra(p1);
              combi.listar();
               Console.WriteLine("\n Removendo.......\n");
              combi.remover(102,p1);
               combi.remover(102,p1);
              combi.listar();

              
        }
    }
}
