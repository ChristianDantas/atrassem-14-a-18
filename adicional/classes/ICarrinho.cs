using System;
using System.Collections.Generic;

namespace adicional.classes
{
    public class ICarrinho : Carrinho
    {
        List<produto> Produto= new List<produto>();
        public void adicionar(int cod, produto novoProduto)
        {
            Produto.Find(x=>x.codigo==cod).nome=novoProduto.nome;
             Produto.Find(x=>x.codigo==cod).preco=novoProduto.preco;
        }

        public void cadastra(produto _Produto)
        {
            Produto.Add(_Produto);
        }

        public void listar()
        {
            foreach (produto item in Produto)
            {
                  Console.WriteLine("codigo:"+ item.codigo);
                    Console.WriteLine("nome:"+ item.nome);
                Console.WriteLine("preço:"+ item.preco);
            }
        }

        public void remover(int cod, produto ProdDelete)
        {
            ProdDelete= Produto.Find(x=>x.codigo==cod);
            if(ProdDelete!=null)
            {
                Produto.Remove(ProdDelete);
            }
        }
    }
}