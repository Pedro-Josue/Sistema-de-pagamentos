namespace Sistema_De_Pagamentos.Model;

public class PagamentoCartao : Pagamento
{
    public string NumeroCartao { get; set; }

    public PagamentoCartao(decimal valor, string numeroCartao) : base(valor)
    {
        NumeroCartao = numeroCartao;
    }

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento de R$ {Valor:N2} via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.";
    }
}
