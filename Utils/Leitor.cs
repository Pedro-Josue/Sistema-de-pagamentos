using System.Globalization;

namespace Sistema_De_Pagamentos.Utils;

public static class Leitor
{
    public static decimal LerDecimal(string mensagem)
    {
        decimal valor;

        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine() ?? "";

            // Troca vírgula por ponto se necessário
            entrada = entrada.Replace(",", ".");

            if (decimal.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) && valor > 0)
                return valor;

            Console.WriteLine("Valor inválido. Digite novamente (ex: 150,50 ou 150.50).");
        }
    }

    public static string LerTexto(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(entrada))
                return entrada;

            Console.WriteLine("Entrada inválida. Digite novamente.");
        }
    }
}

