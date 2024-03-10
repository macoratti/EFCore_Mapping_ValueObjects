namespace EFCoreDomain;

public record ProdutoId(Guid Valor);

//alternativa
//public sealed class ProdutoId
//{
//    public Guid Valor { get; }

//    public ProdutoId()
//    {
//        Valor = Guid.NewGuid();
//    }

//    public ProdutoId(Guid valor)
//    {
//        Valor = valor;
//    }

//    public override bool Equals(object? obj)
//    {
//        if (obj is ProdutoId other)
//            return Valor == other.Valor;
//        return false;
//    }
//}

//    public override int GetHashCode() => Valor.GetHashCode();
//}
//public record ProdutoId(Guid Valor)
//{
//    public ProdutoId() : this(Guid.NewGuid())
//    {
//    }

//    public override bool Equals(object? obj)
//    {
//        if (obj is ProdutoId other)
//            return Valor == other.Valor;
//        return false;
//    }

//    public override int GetHashCode() => Valor.GetHashCode();
//}