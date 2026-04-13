using Sistema_De_Pagamentos.Model;
using Sistema_De_Pagamentos.Utils;
using Sistema_De_Pagamentos.View;

int opcao = 0;

while (opcao != 3)
{
    Console.Clear();
    Menu.ExibirMenu();

    string entradaOpcao = Console.ReadLine() ?? "";

    if (!int.TryParse(entradaOpcao, out opcao))
    {
        Console.WriteLine("Opção inválida. Pressione ENTER para continuar...");
        Console.ReadLine();
        continue;
    }

    Console.Clear();

    switch (opcao)
    {
        case 1:
            ProcessarCartao();
            break;

        case 2:
            ProcessarBoleto();
            break;

        case 3:
            Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 3)
    {
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}

void ProcessarCartao()
{
    decimal valor = Leitor.LerDecimal("Informe o valor do pagamento: ");
    string numeroCartao = Leitor.LerTexto("Informe o número do cartão: ");

    PagamentoCartao pagamento = new PagamentoCartao(valor, numeroCartao);

    Console.WriteLine("\n" + pagamento.ProcessarPagamento());
}

void ProcessarBoleto()
{
    decimal valor = Leitor.LerDecimal("Informe o valor do pagamento: ");
    string codigoBarras = Leitor.LerTexto("Informe o código de barras: ");

    PagamentoBoleto pagamento = new PagamentoBoleto(valor, codigoBarras);

    Console.WriteLine("\n" + pagamento.ProcessarPagamento());
}
