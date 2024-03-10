namespace EFCoreDomain;

public sealed class ProdutoNome
{
    public const int MaxLength = 100;
    public string Valor { get; }
    public ProdutoNome(string valor)
    {
        Valor = valor;
    }
    public static ProdutoNome Create(string valor)
    {
        if (valor.Length is 0 or > MaxLength)
            throw new ArgumentException($"Tamanho deve estar entre 1 e {MaxLength}.", nameof(valor));

        return new ProdutoNome(valor);
    }
}

//alternativa
//public record ProdutoNome(string Valor)
//{
//    public const int MaxLength = 100;

//    // O compilador automaticamente gera um construtor para inicializar a propriedade 'Valor'
//    // de acordo com o parâmetro do construtor

//    // O compilador automaticamente gera métodos como Equals, GetHashCode, ToString e ==

//    public static ProdutoNome Create(string valor)
//    {
//        if (valor.Length is 0 or > MaxLength)
//            throw new ArgumentException($"Tamanho deve estar entre 1 e {MaxLength}.", nameof(valor));

//        return new ProdutoNome(valor); // Construtor primário é usado
//    }
//}
//public record ProdutoNome
//{
//    public const int MaxLength = 100;
//    public string Valor { get; init; }

//    public ProdutoNome(string valor)
//    {
//        if (string.IsNullOrEmpty(valor) || valor.Length > MaxLength)
//            throw new ArgumentException($"Tamanho deve estar entre 1 e {MaxLength}.", nameof(valor));

//        Valor = valor;
//    }

//    public static ProdutoNome Create(string valor)
//    {
//        return new ProdutoNome(valor);
//    }
//}
