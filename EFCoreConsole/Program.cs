using EFCoreConsole.Data;
using EFCoreDomain;

while (true)
{
    Console.WriteLine("### Menu ###\n");
    Console.WriteLine("1. Adicionar Novo Produto");
    Console.WriteLine("2. Listar Produtos");
    Console.WriteLine("3. Sair");
    Console.Write("\nEscolha uma opção: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AddProduto();
            break;
        case "2":
            Consulta();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}
static void AddProduto()
{
    Random random = new Random();

    using (var ctx = new AppDbContext())
    {
        var valorAleatorio = (decimal)random.Next(1, 10);
        var codigoAleatorio = random.Next(11111111, 99999999);

        var novoProduto = new Produto(
            new ProdutoId(Guid.NewGuid()),
            new ProdutoNome($"Novo Produto - {DateTime.Now.Second}"),
            new ValorMonetario(valorAleatorio, "BRL"),
            CodigoProduto.Create(codigoAleatorio.ToString())!
        );

        ctx.Produtos.Add(novoProduto);
        ctx.SaveChanges();

        Console.WriteLine($"\nNovo produto {novoProduto.Nome!.Valor} adicionado com sucesso!");
    }
}
static void Consulta()
{
    using (var ctx = new AppDbContext())
    {
        var produtos = ctx.Produtos.ToList();
        Console.WriteLine("\n###  Lista de Produtos  ###\n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id!.Valor} \t {produto.Nome!.Valor} \t {produto.Preco!.Valor} {produto.Preco.Moeda} \t Código: {produto.CodigoProduto!.Valor}");
        }
    }
}
