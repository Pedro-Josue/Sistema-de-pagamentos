namespace Sistema_De_Pagamentos.Model;

public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime DataPagamento { get; set; }

    protected Pagamento(decimal valor)
    {
        Valor = valor;
        DataPagamento = DateTime.Now;
    }

    public abstract string ProcessarPagamento();
}
