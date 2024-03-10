namespace EFCoreDomain;

public record CodigoProduto
{
    private const int DefaultLength = 8;
    private CodigoProduto(string valor) => Valor = valor;
    public string Valor { get; init; }
    public static CodigoProduto? Create(string valor)
    {
        if (valor?.Length != DefaultLength)
              return new CodigoProduto("00000000"); 

        return new CodigoProduto(valor);
    }
}

//alternativa
//public record CodigoProduto(string Valor)
//{
//    public const int DefaultLength = 8;

//    public static CodigoProduto? Create(string valor)
//    {
//        if (valor?.Length != DefaultLength)
//            return null;

//        return new CodigoProduto(valor);
//    }
//}