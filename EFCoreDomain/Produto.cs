namespace EFCoreDomain;

public class Produto
{
    public ProdutoId? Id { get; private set; }
    public ProdutoNome? Nome { get; private set; }
    public ValorMonetario? Preco { get; private set; }
    public CodigoProduto? CodigoProduto { get; private set; }
    public Produto(){ }
    public Produto(ProdutoId id, ProdutoNome nome,
           ValorMonetario preco, CodigoProduto codigoProduto)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        CodigoProduto = codigoProduto;
    }
}
