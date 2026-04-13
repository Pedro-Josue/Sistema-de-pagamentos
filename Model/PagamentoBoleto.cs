namespace Sistema_De_Pagamentos.Model;

internal class PagamentoBoleto : Pagamento
{
    public string CodigoBarras { get; set; }

    public PagamentoBoleto(decimal valor, string codigoBarras) : base(valor)
    {
        CodigoBarras = codigoBarras;
    }

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento de R$ {Valor:N2} via Boleto (Cod Barra: {CodigoBarras}) na data {DataPagamento:dd/MM/yyyy}.";
    }
}
