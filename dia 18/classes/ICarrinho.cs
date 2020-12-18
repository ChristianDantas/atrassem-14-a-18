namespace dia_18.classes
{
    public interface ICarrinho
    {
         void cadastrar(Produto produto);
        
         void alterar(int cod, Produto novoProduto);
         void deletar(int cod);
          void listar ();
    }
}