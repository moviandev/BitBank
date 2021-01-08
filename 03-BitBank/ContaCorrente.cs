
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numeroCC;
    // ADICIONADO VALOR INICIAL DE 100
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}

