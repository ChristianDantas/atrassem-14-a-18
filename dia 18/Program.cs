using System;
using dia_18.classes;

namespace dia_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart= new Carrinho();
            Produto p1= new Produto();
            p1.codigo= 123;
            p1.Nome= "Playstation 5";
            p1.preco=10000f;

            Produto p2= new Produto();
            p2.codigo= 124;
            p2.Nome= "Xbox Series X";
            p2.preco=5000f;
            
            Produto p3= new Produto();
            p3.codigo= 125;
            p3.Nome= "Computador";
            p3.preco=3000f;

            cart.cadastrar(p1);
            cart.cadastrar(p2);
            cart.cadastrar(p3);
            cart.listar();

            Console.ForegroundColor= ConsoleColor.DarkCyan;
            cart.alterar(p2.codigo, p3);
            cart.listar();

            Console.ForegroundColor= ConsoleColor.DarkRed;
            cart.deletar(p1.codigo);
            cart.listar();
        }
    }
}
