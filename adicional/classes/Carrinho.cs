namespace adicional.classes
{
    public interface Carrinho
    {
         void cadastra(produto Produto);
         void adicionar(int cod, produto novoProduto);
         void remover(int cod, produto ProdDelete);
         void listar();
    }
}