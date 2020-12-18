using System;
using System.Collections.Generic;

namespace dia_18.classes
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho= new List<Produto>();
        public void alterar(int cod, Produto novoProduto)
        {
           carrinho.Find(x=>x.codigo == cod).Nome =novoProduto.Nome;  
             carrinho.Find(x=>x.codigo == cod).preco =novoProduto.preco;   
        }

        public void cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void deletar(int cod)
        {
            Produto prodDelete = carrinho.Find(x=>x.codigo == cod);
            if(prodDelete != null){
                carrinho.Remove(prodDelete);
            }   
        }

        public void listar()
        {
            foreach (Produto item in carrinho){
                Console.WriteLine($"cod : {item.codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preco: {item.preco}");
            }
        }
    }
}