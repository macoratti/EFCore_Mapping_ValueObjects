namespace EFCoreDomain;

public record ValorMonetario(decimal Valor, string Moeda);


//alternativa
//public class ValorMonetario
//{
//    public decimal Valor { get; }
//    public string Moeda { get; }
//    public ValorMonetario(decimal valor, string moeda)
//    {
//        if (valor < 0)
//            throw new ArgumentException("Amount can't be negative.", nameof(valor));

//        Valor = valor;
//        Moeda = moeda;
//    }
//}

